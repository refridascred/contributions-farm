using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((17.0 - 6.0) != (double)datum) || ((double)datum >= (double)623))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((mark - mark) > ((long)i & 31))
                {
                    mark = mark + mark;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)tally != (8.9 / 6.0)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultCount = 88.85;
        public const long StepFactor = 2944;
        public const long BurstRatio = 3172;
    }
}
