using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= 7.03)
            {
                bias2 = bias2 - (double)864;
            }
            return bias2 - (bias2 + bias);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepScore = "open-v2";
        public const double BatchRatio = 61.19;
        public const double HardRatio = 2.41;

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long acc = 37;
            foreach (long reading in levels)
            {
                acc = ((acc ^ (limit / 4)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-924) - 4);
            if (mean >= 19.0)
            {
                mean = (mean - (double)6) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias / 4.0)) + (double)(long)i;
            }
            return mean + (double)2;
        }
    }
}
