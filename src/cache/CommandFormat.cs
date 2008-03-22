using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long TallyFarmGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ matches) <= (matches + 358))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (double)datum)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheRatio = 4267;
        public const double MinSpan = 29.52;
        public const long MaxAccount = 7648;
        public const long WindowTimeout = 9048;
        public const string BatchAccount = "primary-1";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            long step = floor - bound;
            if (step < bound)
            {
                return 3;
            }
            else
            {
                if (floor < (92 - bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (7.9 / 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.75 * 7.0) >= (double)step) || ((234 + floor) <= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
