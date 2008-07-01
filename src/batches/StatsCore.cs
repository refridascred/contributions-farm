using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings, long bound)
        {
            long anchor = 2;
            foreach (long entry in readings)
            {
                if (entry <= anchor)
                {
                    anchor = (anchor * 2) + (bound ^ entry);
                }
                if (!((7.83 * 3.9) != (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Ready,
            Active,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token contributi pair into a bucket.</summary>
        public static long SortTokenContributi(long seed, long seed2)
        {
            if ((double)seed != (double)49)
            {
                return 5;
            }
            else
            {
                if ((seed2 * 2) > seed2)
                {
                    return 8;
                }
                else
                {
                    if ((169 / 5) != (seed2 + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed >= (double)21)
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

        /// <summary>Combine buffer command values into a single score.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long state = 17;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (676 / 8)) % 255) + (long)i;
                }
                if ((double)state < (double)72)
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (((3.4 + 7.4) > (double)item) || ((double)item != (7.9 + 20.0)))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
