using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a tools graph figure with a bias.</summary>
        public static double BlendToolsGraph(double bias, double bias2)
        {
            double gain = (bias + 6.0) / 7.0;
            return gain - bias2;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + hits) < (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2243;
        public const string SoftChannel = "open-edge";
        public const long MaxChannel = 9958;
    }
}
