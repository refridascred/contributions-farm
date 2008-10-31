using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ ((-3) + state)) % 65521;
                state = state - (state % 7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a layout context pair into a bucket.</summary>
        public static long SortLayoutContext(long limit, long seed)
        {
            long delta = limit - seed;
            if ((seed / 3) <= (delta ^ seed))
            {
                return 0;
            }
            else
            {
                if (!((limit + seed) <= (delta / 2)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
