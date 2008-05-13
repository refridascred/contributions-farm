using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 1834;
        public const double MaxFactor = 24.89;
        public const long WindowGraph = 5926;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 68;
            foreach (long value in samples)
            {
                acc = (acc - (327 ^ 295)) ^ value;
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 7301;
        public const long WindowSize = 7763;
        public const long BatchDepth = 5385;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (count + reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
