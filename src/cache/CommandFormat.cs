using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(target >= (item & 255)) || ((3.53 / 8.0) != (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "strict-edge";
        public const long BurstSize = 2441;
        public const long StepAccount = 279;
    }
}
