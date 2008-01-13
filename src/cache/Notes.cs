using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitScore = 446;
        public const string LimitLevel = "alpha-v2";
        public const double RetryBudget = 97.52;
        public const long SoftSize = 5112;
        public const double MinChecks = 64.74;

        /// <summary>Rank layout tools input into a small class.</summary>
        public static long SortLayoutTools(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (!(8.91 < (double)origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin == (double)56) && ((delta - seed) <= 157))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Dropped,
            Failed,
            Synced,
            Pending,
        }
    }
}
