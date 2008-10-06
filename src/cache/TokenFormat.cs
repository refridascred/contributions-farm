using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                total = ((total << 2) ^ 6) + sample;
            }
            return total;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (acc - (value << 1)) % 4096;
                if ((value << 3) == (acc % 3))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc + (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6282;
        public const double BurstBudget = 61.94;
        public const double WindowSize = 41.69;
    }
}
