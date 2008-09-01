using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank window profile input into a small class.</summary>
        public static long BucketWindowProfile(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((seed % 3) != (75 - seed))
            {
                return 7;
            }
            else
            {
                if ((double)slot != (3.93 + 9.7))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 2) < 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

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

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
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
