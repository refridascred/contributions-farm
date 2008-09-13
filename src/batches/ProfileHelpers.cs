using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double floor)
        {
            double mean = (double)5 + (double)836;
            return ((mean + (mean / 4.0)) + rate) + floor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long offset)
        {
            if (((seed << 1) <= (249 * 3)) || ((double)350 == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) != (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 3) > (offset & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
