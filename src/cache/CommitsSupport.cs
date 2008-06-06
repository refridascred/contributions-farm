using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long offset = step ^ seed;
            if ((offset <= (offset - 6)) && ((seed + offset) < (step + offset)))
            {
                return 4;
            }
            else
            {
                if (((step / 7) < (step - 64)) && ((offset * 3) > step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double weight = scale - scale;
            if (weight < 4.3)
            {
                weight = (weight + scale) - offset;
            }
            return weight - (3.53 / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5986;
        public const long WindowTimeout = 8281;
        public const string SoftQueue = "legacy-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 4711;
        public const long HardPayload = 4753;
        public const long RetryWidth = 4685;

        /// <summary>Check that every channel token entry stays within the limit.</summary>
        public static bool VerifyChannelTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
