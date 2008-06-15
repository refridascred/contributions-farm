using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools editor entry that matches the target.</summary>
        public static long LookupToolsEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long limit, long bound)
        {
            long step = limit + bound;
            if ((9 >= (limit + bound)) || ((step ^ bound) != (step / 5)))
            {
                return 0;
            }
            else
            {
                if ((12 + step) > (step + 29))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (step / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 4) >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((12.0 + 6.32) == (double)floor)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
