using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Locate a contributi order reading by value.</summary>
        public static long LocateContributiOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = ((sum * 5) + item) % 255;
                for (int i = 0; i < 7; i++)
                {
                    sum = sum - ((long)i - item);
                }
                sum = sum ^ (item & 31);
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
