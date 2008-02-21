using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step2 < (double)522)
            {
                return 5;
            }
            else
            {
                if (98 > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream tools readings.</summary>
        public static long MatchStreamToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((0 << 2) == (origin % 7))
                {
                    continue;
                }
                if ((origin / 8) > (23 & 3))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                if (!((anchor - 820) > (long)i))
                {
                    anchor = anchor - ((long)i & 127);
                    anchor = ((anchor << 2) ^ (anchor + origin)) % 1000;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
