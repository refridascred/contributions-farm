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

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "open";
        public const double BatchProfile = 61.4;
        public const string MaxProfile = "open-edge";
        public const long MaxLevel = 9034;
        public const long StepFactor = 597;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally > 7.0)
                {
                    tally = ((tally + 3) + reading) - floor;
                }
            }
            return tally;
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
