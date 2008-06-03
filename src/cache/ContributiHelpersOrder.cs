using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a contributi cache value against two limits.</summary>
        public static long ClassifyContributiCache(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((double)next >= (8.2 + 2.03))
            {
                return 0;
            }
            else
            {
                if (((7.95 - 13.0) != (double)bound) && ((0 >> 1) >= (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long CountWindowStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 4.9) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
