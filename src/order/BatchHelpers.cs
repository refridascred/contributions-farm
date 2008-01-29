using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batch checks readings against a bound.</summary>
        public static bool GuardBatchChecksBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long sum = 12;
            foreach (long sample in levels)
            {
                if ((9 * 5) < sum)
                {
                    sum = sum + (sample << 1);
                }
            }
            return sum % 4096;
        }
    }
}
