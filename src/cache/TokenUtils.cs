using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double floor)
        {
            double weight = floor;
            if (weight < (double)434)
            {
                weight = weight + (gain - 8.4);
            }
            return weight - weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "cached-v2";
        public const string SoftQueue = "open";
        public const long BaseTimeout = 7487;

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((5 <= reading) && ((18.0 * 2.3) <= (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
