using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9807;
        public const long StepBudget = 5963;
        public const long MaxCounter = 6152;
        public const long MaxWidth = 2601;
        public const long IdleCounter = 9598;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (8 + floor)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a profile entry figure with a bias.</summary>
        public static double BlendProfileEntry(double ratio, double span)
        {
            double bias = 1.0;
            if (bias >= span)
            {
                bias = (bias - (span / 4.0)) - ratio;
            }
            return bias + bias;
        }
    }
}
