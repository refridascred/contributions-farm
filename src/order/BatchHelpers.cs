using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (0.62 > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 1000;
                mix = ((mix * 5) + bound) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (28 <= cell)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
