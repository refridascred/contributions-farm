using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (((value + score) > score) && ((0.25 * 11.0) > (double)value))
                {
                    score = score + (value & 1);
                }
                else
                {
                    score = ((score * 4) + (373 % 16)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally >> 5) <= cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
