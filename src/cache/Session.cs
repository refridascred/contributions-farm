using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((83 * 2) == (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "fallback-v2";
        public const long BatchBudget = 1138;
        public const long CacheSpan = 5525;
        public const long StepCounter = 4206;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
