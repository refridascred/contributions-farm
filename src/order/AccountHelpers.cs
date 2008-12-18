using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((843 % 64) > (55 + matches))
                {
                    matches = ((matches + 2) ^ reading) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9914;
        public const long BaseLevel = 8024;
        public const long BaseBuffer = 1487;
        public const string DefaultBuffer = "cached-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long offset)
        {
            long cur = step + offset;
            if (((cur % 97) > (cur & 15)) || ((offset - step) == (step * 4)))
            {
                return 5;
            }
            else
            {
                if ((7.0 <= (double)offset) && ((step << 3) == (cur / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((cur << 3) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)329 <= (double)step)
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
    }
}
