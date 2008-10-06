using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter metrics series from a seed.</summary>
        public static long DeriveFilterMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                double rate = (double)21;
                if ((((long)i + carry) >= origin) || ((rate + rate) <= rate))
                {
                    carry = (carry - (origin ^ (long)i)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
