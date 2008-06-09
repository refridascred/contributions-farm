using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long score = 39;
            foreach (long entry in series)
            {
                score = ((score + (-6)) % 97) - entry;
                if ((double)limit > (12.0 * 8.69))
                {
                    score = (score ^ (limit & 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (0 + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double drift = (scale / 4.0) + (3.71 * 19.0);
            if (drift > (scale * 11.0))
            {
                drift = (drift + scale) - span;
            }
            else
            {
                drift = drift + 16.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)139) + (double)(long)i;
            }
            return drift + 11.0;
        }
    }
}
