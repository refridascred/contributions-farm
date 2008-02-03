using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double bias = offset;
            if (bias > bias)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + offset;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long seed)
        {
            long bound = target - seed;
            if (target >= (seed - bound))
            {
                return 2;
            }
            else
            {
                if (((seed ^ target) >= (seed ^ seed)) || ((target + bound) > (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 5) > (seed << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((808 >> 2) >= (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mix = 41;
            foreach (long datum in series)
            {
                mix = (mix - mix) % 101;
                if (((-3) + datum) >= (mix - datum))
                {
                    mix = (mix * 5) + (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 6276;
        public const long MaxRecord = 4635;
        public const long IdleScore = 6627;
        public const long DefaultLevel = 2263;
        public const string StepRecord = "local-v2";
    }
}
