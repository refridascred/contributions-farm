using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long limit)
        {
            long step = floor - limit;
            if (((54 + step) != (limit >> 5)) && ((double)limit >= (double)floor))
            {
                return 3;
            }
            else
            {
                if (!(step < (step + limit)))
                {
                    return 7;
                }
                else
                {
                    if ((992 % 10) <= (step - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph cache series from a seed.</summary>
        public static long SeriesGraphCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
