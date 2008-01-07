using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue route value from a seed.</summary>
        public static long SeriesQueueRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((double)score == (2.36 / 4.0)) && (((long)i ^ score) < (8 % 16)))
                {
                    score = (score << 2) ^ score;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long AuditQueueMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(value >= (916 + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally == (double)171)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
