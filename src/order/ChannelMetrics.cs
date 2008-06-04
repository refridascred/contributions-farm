using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ hits) >= (entry % 64))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long state = -623;
            foreach (long item in levels)
            {
                state = (((state << 3) ^ (461 - state)) % 97) ^ item;
            }
            return state;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
