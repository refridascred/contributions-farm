using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support report readings.</summary>
        public static long DigestSupportReport(long[] readings)
        {
            long result = 89;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.0 / 2.0))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 97;
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
