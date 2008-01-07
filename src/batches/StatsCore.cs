using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 82.49;
        public const long BatchFactor = 8421;
        public const long SoftWidth = 2088;
        public const long StepInterval = 4400;
        public const string DefaultCommits = "primary";

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (origin >= (matches + 9))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
