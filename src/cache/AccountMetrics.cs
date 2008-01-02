using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "primary-v2";
        public const long MinLayout = 8603;
        public const long SoftDepth = 7751;
        public const long BaseLayout = 3206;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9999;
        public const double StepBuffer = 97.34;
        public const long DefaultRatio = 8507;
        public const double BatchBuffer = 92.89;

        /// <summary>Rank contributi token input into a small class.</summary>
        public static long BucketContributiToken(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((floor + seed) > (floor & 31))
            {
                return 0;
            }
            else
            {
                if (cur < seed)
                {
                    return 6;
                }
                else
                {
                    if ((cur + floor) >= (floor & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor * 5) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double mean = 2.4;
            if (mean > (mean / 3.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 9.34;
            }
            return mean - (gain + bias);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state + bound;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
