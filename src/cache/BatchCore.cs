using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings, long bound)
        {
            long sum = 820;
            foreach (long reading in readings)
            {
                sum = (((sum << 2) ^ (reading & 15)) % 4096) - bound;
            }
            return sum % 97;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5662;
        public const long BatchToken = 893;
        public const double RetryFactor = 52.39;
        public const string CacheToken = "staging-edge";
        public const long IdleDepth = 9787;
    }
}
