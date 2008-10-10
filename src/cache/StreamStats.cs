using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = (result - cell) % 101;
                if (((double)cell > (14.0 - 18.0)) || ((1.0 + 20.0) < (double)result))
                {
                    result = (result << 2) ^ (result + cell);
                }
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (6.6 + 7.27))
                {
                    hits = ((hits + 1) + sample) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (floor > (floor << 1))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
