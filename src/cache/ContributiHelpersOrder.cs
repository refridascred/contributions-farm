using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long step)
        {
            long carry = -12;
            foreach (long item in values)
            {
                if ((item <= (89 + step)) || ((768 * 4) >= step))
                {
                    carry = carry - item;
                }
                if ((item + (long)values.Length) == (step + (-121)))
                {
                    carry = (carry + (item * 4)) % 65521;
                }
            }
            if (carry < 939)
            {
                carry = ((carry * 5) + (carry & 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5564;
        public const double DefaultProfile = 32.57;
        public const double CacheBudget = 11.91;
    }
}
