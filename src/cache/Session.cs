using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9068;
        public const double MinFormat = 68.07;
        public const long WindowFormat = 5090;
        public const string DefaultBudget = "local";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long BucketToolsCache(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((seed + prev) != (seed >> 2))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 2.5) > (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
