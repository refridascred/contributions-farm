using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long mark = -11;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (cell & 7)) % 4096) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 66.5;
        public const long StepOrder = 7521;
        public const long RetryOrder = 2855;
    }
}
