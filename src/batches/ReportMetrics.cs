using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 6440;
        public const string IdleCommand = "local";
        public const long BurstCommand = 4929;
        public const long DefaultSpan = 9894;
        public const long HardCommand = 1236;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                long tally = (target + target) ^ (anchor + target);
                if (!((342 / 4) <= (target + tally)))
                {
                    tally = ((tally * 5) + (tally * 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
