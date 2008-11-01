using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitDepth = "local-1";
        public const long DefaultRatio = 1361;
        public const long BaseBatch = 2670;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long carry = 642;
            foreach (long value in readings)
            {
                carry = ((carry + carry) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Stale,
            Done,
            Pending,
        }
    }
}
