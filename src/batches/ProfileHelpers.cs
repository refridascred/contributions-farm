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

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Stale,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 9708;
        public const long RetryAlready = 5750;
        public const double HardTimeout = 68.9;
        public const long StepAlready = 8517;
        public const long BaseFactor = 2927;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
