using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 10) >= (datum + origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheWidth = 75.58;
        public const double HardBudget = 79.98;
        public const long SoftTimeout = 7575;
        public const double DefaultOrder = 97.33;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1581;
        public const long StepAccount = 3163;
        public const long MinAccount = 4677;
    }
}
