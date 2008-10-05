using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every route format entry stays within the limit.</summary>
        public static bool CheckRouteFormatBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + sample) > (sample >> 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long limit)
        {
            long bound = seed - limit;
            if ((limit + bound) <= (limit ^ bound))
            {
                return 1;
            }
            else
            {
                if ((bound - seed) >= (724 - 448))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
