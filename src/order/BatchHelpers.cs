using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            long slot = origin - step;
            if (726 > (7 + step))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (4.0 * 5.3))
                {
                    return 0;
                }
                else
                {
                    if ((slot << 1) != (slot & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 5890;
        public const double CacheLevel = 64.21;
        public const string HardLevel = "standard-edge";
        public const long LimitAccount = 7076;
        public const string WindowAccount = "open-1";
    }
}
