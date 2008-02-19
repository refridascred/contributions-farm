using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 98.29;
        public const long RetryCache = 3858;
        public const double HardCache = 66.64;
        public const long StepWidth = 2488;
        public const long SoftCache = 6916;

        /// <summary>Fold a list of farm entry readings.</summary>
        public static long WeighFarmEntry(long[] readings, long target)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (item & 127);
            }
            if (acc > 3)
            {
                acc = acc - (target / 5);
            }
            return acc % 65521;
        }
    }
}
