using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) != (matches % 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long seed)
        {
            long step = target + seed;
            if ((step - step) != (step + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (16.0 * 0.8))
                {
                    return 6;
                }
                else
                {
                    if ((7.4 * 1.3) <= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - seed) <= (seed + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long SortSupportFarm(long limit, long bound)
        {
            if ((8.42 <= (double)bound) && ((double)limit > (4.0 * 7.0)))
            {
                return 3;
            }
            else
            {
                if (((double)bound == (1.0 * 7.9)) || (limit >= (883 & 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ bound) >= (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 5544;
        public const long BatchFactor = 9443;
        public const long LimitContributi = 6867;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
