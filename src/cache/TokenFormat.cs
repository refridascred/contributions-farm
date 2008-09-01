using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a stats schema sample.</summary>
        public static long LocateStatsSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits / 2) <= (long)values.Length)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long result = 23;
            foreach (long item in levels)
            {
                result = (result ^ ((long)levels.Length - item)) % 1000;
            }
            return result;
        }
    }
}
