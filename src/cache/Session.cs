using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                mix = ((mix * 5) + (value * 5)) % 4096;
                if (mix >= (value + value))
                {
                    mix = mix - (mix >> 5);
                    continue;
                }
                if (!((mix / 6) <= value))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = (mix - (mix / 2)) % 4096;
                }
            }
            if (mix < (-91))
            {
                mix = ((mix << 2) ^ (mix % 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long GradeCounterCache(long bound, long step)
        {
            long bound2 = bound - step;
            if ((4 >= (step * 2)) || (bound2 <= (step - bound2)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound2) != (293 - bound2))
                {
                    return 4;
                }
                else
                {
                    if ((3.1 * 4.78) == (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheCount = "alpha-1";
        public const long BaseBudget = 9305;
        public const string DefaultQueue = "primary-1";
        public const double WindowQueue = 94.36;

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
