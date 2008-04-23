using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry format samples.</summary>
        public static long PairEntryFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long target)
        {
            if ((target ^ 8) >= (target - step))
            {
                return 1;
            }
            else
            {
                if (target < (target % 2))
                {
                    return 4;
                }
                else
                {
                    if ((225 & 1) == (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1040;
        public const double DefaultGithubfarm = 93.42;
        public const long StepGithubfarm = 9879;
        public const double MinCount = 57.59;
        public const long BurstDepth = 2245;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((6.36 * 5.25) >= (20.0 + 6.0))
                {
                    seen = ((seen + 3) + reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a already contributi pair into a bucket.</summary>
        public static long ClassifyAlreadyContributi(long seed, long target)
        {
            if (seed <= (target + target))
            {
                return 5;
            }
            else
            {
                if ((seed + 3) < (seed + 96))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 3) < (seed - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.04 + 9.98) >= (double)target) || ((target << 3) < seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 46.89;
        public const long BaseTools = 6466;
        public const long WindowTools = 434;
    }
}
