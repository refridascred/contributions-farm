using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((edge - step) <= (origin & 1))
            {
                return 5;
            }
            else
            {
                if ((step & 31) >= (origin >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 5) > (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (822 < (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a token filter reading by value.</summary>
        public static long LookupTokenFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
