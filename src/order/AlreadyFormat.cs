using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two filter farm measurements.</summary>
        public static double BlendFilterFarm(double bias, double span)
        {
            double scale = 17.0;
            if (scale < (10.0 * 6.9))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale / 6.0)) - (double)(long)i;
            }
            return scale + (span * 8.0);
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long target)
        {
            if (((double)target == (4.0 - 19.0)) && ((target + origin) >= origin))
            {
                return 0;
            }
            else
            {
                if ((origin - target) < (target + origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin >> 5) <= target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target > (double)4) || ((double)target == (1.7 - 2.85)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 8510;
        public const double CacheCommand = 61.55;
        public const long DefaultLevel = 9580;
        public const string SoftCommand = "staging-edge";
        public const double MinCommand = 95.24;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
