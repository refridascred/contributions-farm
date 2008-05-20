using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long bound)
        {
            if (!((double)bound <= 8.0))
            {
                return 0;
            }
            else
            {
                if ((target + 723) <= (target & 3))
                {
                    return 8;
                }
                else
                {
                    if (!((double)target < 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((368 - target) > (bound + 711))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics notes pairs that satisfy a relation.</summary>
        public static long PairMetricsNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
