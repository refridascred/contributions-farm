using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((20.0 * 12.0) >= (double)seed))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 9560;
        public const long MinGraph = 4305;
        public const long BatchScore = 7852;

        /// <summary>Project the next graph cache value.</summary>
        public static double BlendGraphCache(double scale, double floor)
        {
            double load = scale;
            if (load <= (double)34)
            {
                load = load + floor;
            }
            else
            {
                load = load - (3.3 - 4.79);
            }
            return load + 8.0;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (996 < (37 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long target)
        {
            if (((target + target) > (target * 4)) || (75 < target))
            {
                return 6;
            }
            else
            {
                if (bound < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= 366) || ((target + 150) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (867 + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
