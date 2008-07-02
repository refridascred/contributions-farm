using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-v2";
        public const long BatchWidth = 7509;
        public const long SoftFormat = 71;
        public const double MinDepth = 83.41;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
