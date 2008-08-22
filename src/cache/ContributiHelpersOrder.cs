using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            long lane = seed + limit;
            if ((lane ^ lane) <= (limit << 2))
            {
                return 0;
            }
            else
            {
                if (((limit / 7) != (seed + lane)) && ((seed ^ limit) < lane))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 5) == (lane * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + lane) <= (limit / 9)) && (9 > (limit % 10)))
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
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
