using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            New,
            Locked,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 58.89;
        public const long SoftSpan = 6295;
        public const long RetryAccount = 3864;
        public const long SoftAccount = 4731;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values)
        {
            long carry = 92;
            foreach (long reading in values)
            {
                if ((5.3 + 3.9) == (double)reading)
                {
                    carry = (carry << 3) ^ (carry * 2);
                }
                else
                {
                    carry = (carry - (reading * 3)) % 101;
                }
            }
            if (carry < 57)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 1000;
        }
    }
}
