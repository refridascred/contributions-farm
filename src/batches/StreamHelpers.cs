using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 54.44;
        public const long BatchSpan = 5071;
        public const long BatchRatio = 4515;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Closed,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Done,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6054;
        public const double BatchLevel = 71.25;
        public const double LimitSpan = 20.9;
        public const long IdleRatio = 2093;
        public const long HardInterval = 9245;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 1366;
        public const long BatchWidth = 4433;
        public const long DefaultCommits = 2744;
        public const long MaxCommits = 7712;
        public const long MinCommits = 7056;
    }
}
