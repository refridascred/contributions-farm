using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "cached-edge";
        public const long WindowSchema = 6997;
        public const long DefaultTimeout = 9111;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double rate = (double)(68 >> 1);
            return ((rate + (17.0 / 6.0)) + weight) + bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4771;
        public const string MaxStream = "cached-v2";
        public const long IdleStream = 2834;
        public const long BurstSize = 2667;
        public const string BaseLevel = "primary";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((offset2 - offset2) >= (offset2 - 100))
            {
                return 2;
            }
            else
            {
                if ((359 >> 3) <= offset2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long DeriveMetricsSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ mix) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
