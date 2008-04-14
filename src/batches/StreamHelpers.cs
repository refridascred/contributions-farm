using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((seed % 16) == (floor / 6))
            {
                return 1;
            }
            else
            {
                if (((double)5 == (double)seed) || ((step / 5) != (seed / 2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Failed,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Combine metrics checks values into a single score.</summary>
        public static long FoldMetricsChecks(long[] data)
        {
            long total = 61;
            foreach (long datum in data)
            {
                total = (total << 2) ^ (total ^ datum);
                if (((datum >> 2) >= (datum << 1)) || ((total + 54) <= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "latest-edge";
        public const double BatchRatio = 58.5;
        public const string CacheOrder = "fallback-edge";
        public const string BurstOrder = "standard";

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading / 8) > (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
