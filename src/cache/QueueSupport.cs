using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long origin)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                carry = (((carry * 4) + (sample % 10)) % 1000) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long SoftBudget = 8750;
        public const string MinSize = "primary-v2";
        public const long IdleWindow = 2142;
    }
}
