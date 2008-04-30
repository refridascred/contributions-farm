using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            long slot = offset + seed;
            if ((seed ^ offset) >= (offset >> 5))
            {
                return 7;
            }
            else
            {
                if ((slot / 9) < offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 8643;
        public const double LimitScore = 54.23;
        public const long LimitReport = 1092;
        public const long BatchBudget = 8328;
        public const double MaxReport = 92.49;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Paused,
            Done,
            New,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
