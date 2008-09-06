using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((19 + item) == (target * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter entry readings.</summary>
        public static long TallyFilterEntry(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if (state < entry)
                {
                    state = (state + state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxRatio = 3838;
        public const string BaseFactor = "fallback-1";
        public const long BaseInterval = 5332;
        public const long HardBatch = 2618;
        public const long CacheRatio = 972;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Closed,
            Active,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (seen + 4))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
