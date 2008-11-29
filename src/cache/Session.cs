using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next session format value from a seed.</summary>
        public static long StepSessionFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 5596;
        public const long DefaultSize = 3854;
        public const long MinStats = 665;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) >= datum)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }
    }
}
