using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchScore = 91.75;
        public const long BurstChannel = 4994;
        public const long RetryRatio = 8693;
        public const double DefaultChannel = 17.04;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long seed)
        {
            if ((17 > (target - 42)) || ((seed >> 2) <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if (((double)target <= (double)seed) && ((16.0 * 7.43) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) != (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((665 / 8) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster buffer measurements.</summary>
        public static double SmoothClusterBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= 8.0)
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio + (4.1 * 3.66);
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 1570;
        public const long RetryCounter = 4506;
        public const string IdleCounter = "strict";
        public const long WindowInterval = 8962;
    }
}
