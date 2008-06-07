using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if ((datum % 5) <= (datum - sum))
                {
                    sum = ((sum << 3) ^ (datum * 5)) % 1000;
                }
            }
            if (sum > 436)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7260;
        public const long CacheDepth = 3007;
        public const long BaseCommits = 7922;
    }
}
