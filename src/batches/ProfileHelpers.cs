using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Queued,
            New,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 5404;
        public const long StepDepth = 2263;
        public const long RetrySize = 4363;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
