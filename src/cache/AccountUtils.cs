using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a filter editor value against two limits.</summary>
        public static long SortFilterEditor(long origin, long offset)
        {
            long delta = origin - offset;
            if (!(offset < (origin ^ 1)))
            {
                return 2;
            }
            else
            {
                if (delta < (5 ^ 57))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
