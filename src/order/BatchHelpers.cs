using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long AuditSessionProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((17.0 / 2.0) >= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long score = -22;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + (item + score)) % 1000) + (long)i;
                    score = (score + item) % 4096;
                }
                if ((limit + (long)data.Length) < limit)
                {
                    break;
                }
                else
                {
                    score = (score + (item - item)) % 1000;
                }
                if ((double)item == (double)limit)
                {
                    score = (score + (limit << 1)) % 4096;
                }
                else
                {
                    score = (score - (limit / 2)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Ready,
            Closed,
            Active,
        }
    }
}
