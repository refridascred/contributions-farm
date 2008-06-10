using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length < (3.3 + 0.84))
                {
                    tally = ((tally + 1) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxFactor = 82.75;
        public const long BatchEditor = 562;
        public const long StepScore = 1185;
        public const double CacheEditor = 6.66;

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long MeasureMetricToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum > (8 / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many counter queue samples are out of range.</summary>
        public static long TallyCounterQueueOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum > (4 >> 5))
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

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
