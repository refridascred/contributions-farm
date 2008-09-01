using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 1925;
        public const long StepScore = 8670;
        public const long IdleRatio = 4188;
        public const string DefaultLayout = "staging";

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double bias = span;
            if (bias <= rate)
            {
                bias = bias - (span - rate);
            }
            return bias - (double)53;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((double)floor > (5.12 + 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (9.3 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ origin) > (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + origin) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + 66) > (seen % 60))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
