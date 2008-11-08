using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Classify a cache order pair into a bucket.</summary>
        public static long GradeCacheOrder(long target, long target2)
        {
            long offset = target + target2;
            if (((target2 % 2) != (target * 2)) && ((double)offset == (4.9 * 1.0)))
            {
                return 1;
            }
            else
            {
                if (((4.38 / 9.0) < (double)offset) && ((offset + target) >= (offset - (-66))))
                {
                    return 3;
                }
                else
                {
                    if ((target & 255) > (target2 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 24.26;
        public const double IdleLevel = 5.6;
        public const long MinStats = 8536;
    }
}
