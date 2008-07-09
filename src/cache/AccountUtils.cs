using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 2688;
        public const long BatchFilter = 1813;
        public const long HardFilter = 3303;
        public const long HardDepth = 578;

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if ((double)carry > (double)sample)
                {
                    carry = carry - sample;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
