using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support layout input into a small class.</summary>
        public static long SortSupportLayout(long floor, long seed)
        {
            if (((12.0 / 7.0) > (double)floor) && (floor < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= (floor % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Synced,
            Active,
            Done,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 461;
        public const long BaseSize = 2263;
        public const double BaseFactor = 20.21;
        public const string LimitCommand = "local-edge";
    }
}
