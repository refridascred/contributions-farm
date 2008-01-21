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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long seed2)
        {
            long delta = seed - seed2;
            if ((seed ^ seed2) < delta)
            {
                return 0;
            }
            else
            {
                if (((seed & 127) == (delta << 3)) || ((seed ^ seed2) != (86 ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((24 % 60) >= seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta >> 5) >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
