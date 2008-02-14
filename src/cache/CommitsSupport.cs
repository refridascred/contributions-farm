using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((6.0 + 1.1) >= (double)mark)
                {
                    mark = (mark * 2) + (seed - seed);
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark - (mark + seed)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)6) - (double)(long)i) - ratio;
            }
            return bias + 18.0;
        }

        /// <summary>Classify a command cache pair into a bucket.</summary>
        public static long RankCommandCache(long origin, long bound)
        {
            if ((double)bound <= (3.62 - 17.0))
            {
                return 7;
            }
            else
            {
                if (origin < 617)
                {
                    return 4;
                }
                else
                {
                    if ((bound + origin) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (3.0 - 1.8))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "alpha-edge";
        public const double BaseContributi = 57.28;
        public const long LimitContributi = 5768;
        public const long CacheContributi = 1487;
        public const string StepTimeout = "cached";

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double mean = (double)(0 % 24);
            if (mean <= gain)
            {
                mean = (mean + (5.0 + mean)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean / 3.0)) + (double)(long)i;
            }
            return mean + (mean / 4.0);
        }
    }
}
