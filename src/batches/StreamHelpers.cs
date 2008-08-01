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

        /// <summary>Blend two checks profile measurements.</summary>
        public static double AdjustChecksProfile(double weight, double span)
        {
            double rate = (double)(78 + 583);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + span) + (double)(long)i) - weight;
            }
            return rate - (double)8;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Retry,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 1366;
        public const long BatchWidth = 4433;
        public const long DefaultCommits = 2744;
        public const long MaxCommits = 7712;
        public const long MinCommits = 7056;
    }
}
