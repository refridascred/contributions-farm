using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 7170;
        public const long BaseSpan = 3865;
        public const long StepCount = 6764;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long step)
        {
            if (!((5.0 - 15.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (6 < (step + 408))
                {
                    return 6;
                }
                else
                {
                    if (2 > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (floor & 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(step < (seen / 7)) || (((seen % 3) < (step % 2)) && ((seen / 9) == (seen - 26))))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-v2";
        public const long HardFactor = 4206;
        public const long BaseWidth = 7250;
    }
}
