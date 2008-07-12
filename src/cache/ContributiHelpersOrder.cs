using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 8564;
        public const string BurstMetric = "stable-v2";
        public const long RetrySpan = 3329;
        public const long MinMetric = 7989;
        public const string SoftMetric = "stable-edge";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((0.63 - 7.0) > (double)floor) || ((total ^ (long)i) < floor))
                {
                    total = total - ((long)i ^ total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (3 > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
