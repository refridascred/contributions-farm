using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long total = 51;
            foreach (long value in series)
            {
                total = total ^ value;
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ (value * 5)) % 1000) ^ (long)i;
                }
                if ((737 - total) > value)
                {
                    total = (total + (total ^ 15)) % 65521;
                }
                else
                {
                    total = ((total * 3) + (total << 1)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 1336;
        public const double IdleBuffer = 11.52;
        public const double BurstBuffer = 43.55;

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
