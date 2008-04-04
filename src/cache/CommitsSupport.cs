using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long seed)
        {
            if (((double)bound < (6.79 / 5.0)) || ((double)971 < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)970 < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((bound + seed) >= (bound + bound)) && ((seed % 24) > (bound & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (2.6 / 6.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long SeriesCacheCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (((sample << 3) == (sample % 64)) && ((3.0 / 6.0) == (double)mark))
                {
                    mark = (mark << 3) ^ (offset - sample);
                    break;
                }
                mark = ((mark * 2) + (mark * 4)) % 97;
            }
            if (mark > 12)
            {
                mark = ((mark << 3) ^ (offset / 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Active,
            Done,
            Closed,
        }
    }
}
