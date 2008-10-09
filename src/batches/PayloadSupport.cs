using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long origin)
        {
            if (((origin >> 4) >= (origin & 1)) || ((double)origin == (8.5 / 9.0)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 4) != (origin & 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 4) <= ((-79) + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin & 7) == (origin - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a layout stats reading by value.</summary>
        public static long LookupLayoutStatsIndex(long[] values, long bound)
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
    }
}
