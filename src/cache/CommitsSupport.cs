using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of filter batch readings.</summary>
        public static long CombineFilterBatch(long[] data, long step)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if (step >= (sample - sample))
                {
                    state = state + step;
                }
                if ((sample - step) > step)
                {
                    state = (state - ((-53) - sample)) % 97;
                }
                state = (state * 2) + sample;
                if (state <= (0 % 8))
                {
                    break;
                }
            }
            if (state < 936)
            {
                state = (state ^ (state + step)) % 1000;
            }
            return state;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((594 <= (248 + edge)) || ((double)limit <= (6.8 * 18.0)))
            {
                return 2;
            }
            else
            {
                if ((offset / 6) == (limit + 99))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ edge) >= (edge & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((edge - edge) < (offset << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long TallyClusterChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!(((-219) <= tally) && ((limit >> 5) >= item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
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
