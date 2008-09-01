using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const long MinOrder = 7313;
        public const string HardOrder = "stable";
        public const long StepOrder = 3513;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 - seed) <= seed2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 > (3.34 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Active,
            Done,
        }
    }
}
