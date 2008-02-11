using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0.5 + 7.0) <= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (8 / 4)) ^ cell;
            }
            return acc;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = 8.5 - bias;
            if (drift > offset)
            {
                drift = drift + (drift - 0.3);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset / 5.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long offset)
        {
            long score = 69;
            foreach (long item in samples)
            {
                if ((double)score != (3.03 * 3.69))
                {
                    score = (((score + ((long)samples.Length % 16)) % 1000) - item) - offset;
                }
            }
            return score % 1000;
        }
    }
}
