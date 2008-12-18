using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.5 - 0.1) == (double)cell)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double rate = ratio;
            return (rate - 2.0) + span;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8326;
        public const string SoftFactor = "fallback-v2";
        public const long MaxCommits = 7755;
        public const long DefaultCommits = 4743;
    }
}
