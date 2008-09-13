using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((79 << 3) <= (datum >> 5)) || (datum > step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
