using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count token order pairs that satisfy a relation.</summary>
        public static long MatchTokenOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > (value + hits))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((6.64 * 11.0) >= (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 3) < (seen & 7))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
