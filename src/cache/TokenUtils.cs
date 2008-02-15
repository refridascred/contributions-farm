using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long target)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if ((sample / 9) > sum)
                {
                    sum = sum - (target & 3);
                }
            }
            if (sum < 515)
            {
                sum = (sum ^ (target + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 88.74;
        public const double CacheFactor = 48.4;
        public const long SoftInterval = 6056;
        public const long DefaultBatch = 7342;
        public const long MaxBatch = 6782;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
