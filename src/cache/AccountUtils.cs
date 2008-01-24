using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long MeasureRouteChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) <= (1 % 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Dropped,
            Retry,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "stable-v2";
        public const long DefaultBudget = 8521;
        public const long LimitDepth = 1391;
        public const long MinWindow = 2709;
    }
}
