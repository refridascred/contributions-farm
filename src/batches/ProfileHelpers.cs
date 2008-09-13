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

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long DigestClusterCache(long[] series)
        {
            long anchor = 448;
            foreach (long entry in series)
            {
                if (!((double)anchor >= (7.0 / 4.0)))
                {
                    anchor = (((anchor << 3) ^ (anchor + (long)series.Length)) % 1000) - entry;
                }
            }
            return anchor % 4096;
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
