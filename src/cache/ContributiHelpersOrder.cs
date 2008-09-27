using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long total = -14;
            foreach (long item in levels)
            {
                if ((4.05 - 6.4) != (double)total)
                {
                    total = total ^ (item >> 3);
                }
                else
                {
                    total = (total - 890) % 1000;
                }
                if (((-944) >= (total + 689)) && ((total + total) < item))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total * 3) + (total + total);
            }
            return total % 97;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long sum = 824;
            foreach (long sample in series)
            {
                sum = (((sum * 3) + (sum & 255)) % 4096) + sample;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 329;
        public const long LimitChannel = 4120;
        public const long BurstChannel = 1439;
        public const long CacheTimeout = 9540;
        public const string HardChannel = "alpha-v2";
    }
}
