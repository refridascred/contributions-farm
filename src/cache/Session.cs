using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            if ((double)floor < (double)floor2)
            {
                return 4;
            }
            else
            {
                if ((floor2 & 63) != (floor2 + floor2))
                {
                    return 8;
                }
                else
                {
                    if (floor2 <= (41 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 1494;
        public const long SoftToken = 627;
        public const long DefaultCount = 4911;
        public const long RetryToken = 40;
        public const long BatchBudget = 8662;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
