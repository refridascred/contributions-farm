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

        /// <summary>Digest a series of counter cluster entries.</summary>
        public static long WeighCounterCluster(long[] readings)
        {
            long sum = 998;
            foreach (long sample in readings)
            {
                sum = (sum - (sample + sample)) % 4096;
            }
            return sum % 4096;
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
