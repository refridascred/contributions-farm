using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((9.6 + 4.6) != (double)entry) || ((hits >> 4) > entry)) && (entry >= (entry + (-518))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((12.0 / 8.0) <= (double)tally)
                {
                    tally = ((tally + 2) + value) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if (limit < (limit << 3))
                {
                    score = ((score * 5) + 781) % 255;
                    score = score + 3;
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] samples, long limit)
        {
            long mix = 25;
            foreach (long entry in samples)
            {
                mix = ((mix ^ (limit / 2)) % 1000) ^ entry;
            }
            return mix % 97;
        }
    }
}
