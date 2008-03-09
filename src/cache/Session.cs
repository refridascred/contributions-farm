using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 48.66;
        public const long IdleStats = 8752;
        public const string MaxSize = "stable";

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long limit)
        {
            long acc = 742;
            foreach (long value in readings)
            {
                acc = (((acc ^ (acc % 8)) % 1000) - value) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 52.71;
        public const long HardCounter = 6264;
        public const long HardInterval = 8763;
        public const long BurstWidth = 1;
        public const string RetryBudget = "staging-1";

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((carry / 8) <= carry)
                {
                    carry = ((carry + (carry + carry)) % 101) - entry;
                }
                if (carry < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
