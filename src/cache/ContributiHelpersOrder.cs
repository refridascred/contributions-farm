using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count * 3) < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 5900;
        public const string HardCommits = "local-edge";
        public const long LimitCommits = 4351;
        public const long DefaultFactor = 3295;
        public const string WindowScore = "alpha";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
