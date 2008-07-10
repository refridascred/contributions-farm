using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3291;
        public const long IdleTimeout = 9270;
        public const long HardInterval = 5702;
        public const double IdleRoute = 42.95;

        /// <summary>Derive the next tools githubfarm value from a seed.</summary>
        public static long IterateToolsGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - (long)i) != (state * 5))
                {
                    break;
                }
                if ((state - state) > ((-3) + state))
                {
                    state = state - target;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long bound)
        {
            if ((bound + bound) >= bound)
            {
                return 7;
            }
            else
            {
                if ((9.16 * 4.4) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((step / 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound ^ step) >= 306))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = result ^ sample;
                result = ((result * 5) + sample) % 4096;
                result = ((result * 4) + (66 - bound)) % 101;
            }
            if (result < 637)
            {
                result = (result - (bound - bound)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of cache batch readings.</summary>
        public static long MatchCacheBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report tools pairs that satisfy a relation.</summary>
        public static long PairReportToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
