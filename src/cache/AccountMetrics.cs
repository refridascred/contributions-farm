using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) > (89 >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Queued,
            Stale,
            New,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "latest";
        public const long BurstSize = 1452;
        public const double MaxCounter = 82.49;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "open";
        public const long BaseLayout = 1196;
        public const double HardSpan = 86.77;
        public const long IdleSize = 3228;
        public const string BurstLayout = "stable-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5069;
        public const double BaseGraph = 36.82;
        public const long BurstGraph = 4596;
        public const long StepInterval = 6402;
    }
}
