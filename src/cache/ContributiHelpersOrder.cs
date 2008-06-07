using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 8375;
        public const string LimitNotes = "stable-1";
        public const long DefaultDepth = 7545;
        public const double BurstScore = 66.15;
        public const string MinLevel = "local";

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long floor)
        {
            long mark = 70;
            foreach (long item in data)
            {
                if (((972 + item) > (33 + mark)) && ((double)floor < (double)0))
                {
                    continue;
                }
                if (((item & 7) >= item) || ((double)mark != (14.0 + 6.7)))
                {
                    mark = ((mark * 3) + (mark - 866)) % 101;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark;
        }
    }
}
