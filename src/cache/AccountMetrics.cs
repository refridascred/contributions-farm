using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ (cell - cell)) % 255;
                if ((cell % 16) >= offset)
                {
                    mix = (mix * 4) + (cell ^ (-43));
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix & 7)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double ratio = 7.92;
            if (ratio < (double)312)
            {
                ratio = ratio - (ratio + span);
            }
            return ratio + weight;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a command already value against two limits.</summary>
        public static long RankCommandAlready(long seed, long offset)
        {
            long slot = seed + offset;
            if ((seed & 255) <= slot)
            {
                return 6;
            }
            else
            {
                if ((seed ^ seed) > (24 + 666))
                {
                    return 8;
                }
                else
                {
                    if ((slot ^ seed) < seed)
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

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseSize = "fallback-edge";
        public const double SoftFilter = 25.04;
        public const long WindowFilter = 7772;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 4060;
        public const long MaxFormat = 4624;
        public const double DefaultFactor = 29.12;
    }
}
