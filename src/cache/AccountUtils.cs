using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 6249;
        public const string WindowPayload = "strict-edge";
        public const long HardRatio = 1980;
        public const long DefaultPayload = 8390;
        public const double LimitSpan = 19.3;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 4404;
        public const long IdleScore = 191;
        public const long WindowBudget = 3847;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long acc = 44;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ ((long)i / 2)) % 97;
                }
                if (step <= cell)
                {
                    acc = (acc + 9) % 65521;
                }
                if ((7.34 + 2.8) == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
