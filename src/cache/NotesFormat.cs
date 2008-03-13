using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (limit < (499 / 2))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double load = (weight / 9.0) * 9.09;
            if (load >= (weight / 3.0))
            {
                load = (load + load) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (4.0 - 9.26)) + (double)(long)i;
            }
            return load - 6.7;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long target)
        {
            long acc = -63;
            foreach (long datum in levels)
            {
                acc = ((acc * 5) + (datum ^ acc)) % 255;
                if (datum >= (datum - 8))
                {
                    acc = ((acc << 2) ^ (target * 3)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
