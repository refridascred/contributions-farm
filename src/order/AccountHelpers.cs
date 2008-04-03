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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long state = 59;
            foreach (long datum in levels)
            {
                if ((datum % 100) > state)
                {
                    state = state - state;
                }
                state = (state - datum) % 101;
            }
            if (state < 1)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

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
