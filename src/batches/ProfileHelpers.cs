using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double load = (double)(52 % 3);
            return ((load - load) + weight) + bias;
        }

        /// <summary>Rank window order input into a small class.</summary>
        public static long BucketWindowOrder(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((6 < floor) || ((bound * 5) > (floor & 255)))
            {
                return 8;
            }
            else
            {
                if ((floor2 * 2) > floor2)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseWidth = 1463;
        public const string CacheRatio = "alpha-1";
        public const long BurstScore = 8448;
        public const long IdleFormat = 4818;

        /// <summary>Combine session context values into a single score.</summary>
        public static long DigestSessionContext(long[] samples, long origin)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                mix = (mix ^ (value + mix)) % 97;
                if (17.0 > (double)origin)
                {
                    mix = (mix + (mix >> 2)) % 101;
                }
            }
            if (mix < 868)
            {
                mix = ((mix << 2) ^ (mix ^ 369)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
