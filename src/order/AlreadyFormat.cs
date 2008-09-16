using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items, long bound)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if ((17.0 / 2.0) > (double)bound)
                {
                    mix = ((mix * 2) + bound) - item;
                }
                else
                {
                    mix = ((mix << 2) ^ bound) % 97;
                }
            }
            return mix % 97;
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
