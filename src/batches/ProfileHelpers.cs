using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "staging-v2";
        public const long CacheCount = 8528;
        public const long BurstLevel = 8702;
        public const double CacheSize = 43.35;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long step)
        {
            if (!((step / 7) <= step))
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((-158) / 3) >= (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum - (long)i)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
