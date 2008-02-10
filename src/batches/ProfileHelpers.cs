using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 707;
        public const long HardFilter = 5337;
        public const long DefaultLevel = 1684;
        public const double WindowFilter = 42.4;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((step - matches) <= (datum + step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 6031;
        public const string DefaultNotes = "strict-edge";
        public const long MinInterval = 7822;
        public const string MaxNotes = "local-edge";
        public const double MaxTimeout = 19.89;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstFactor = 10.71;
        public const long BatchFactor = 4275;
        public const string BatchTools = "local-edge";
        public const double HardTools = 44.59;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 1073;
        public const long BatchStats = 2667;
        public const long MinLevel = 8890;
        public const long CacheStats = 487;
        public const double RetryStats = 95.62;
    }
}
