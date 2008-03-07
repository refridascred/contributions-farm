using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the report tools entries that pass the check.</summary>
        public static long TallyReportToolsMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)reading != (11.0 / 3.0)) && ((double)seen >= (6.91 * 7.11)))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account command series from a seed.</summary>
        public static long SeriesAccountCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long BucketCounterContributi(long bound, long limit)
        {
            if ((bound >> 5) < (bound * 2))
            {
                return 0;
            }
            else
            {
                if (bound >= limit)
                {
                    return 3;
                }
                else
                {
                    if (58 > (limit ^ 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) <= (limit >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long anchor = 44;
            foreach (long cell in values)
            {
                if ((limit % 8) > (cell % 5))
                {
                    anchor = (anchor - 9) % 65521;
                }
                if (((84 * 5) == (cell * 5)) && ((cell + limit) <= (20 * 5)))
                {
                    break;
                }
            }
            if (anchor > 40)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (state >= ((long)i - bound))
                {
                    state = state ^ ((long)i - bound);
                }
                state = ((state << 3) ^ (bound / 4)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
