using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double scale2 = (1.0 * 0.91) - 5.75;
            if (scale2 >= scale)
            {
                scale2 = scale2 + (scale2 + 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - (double)610;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen >= (double)(long)samples.Length) && (origin >= (cell + origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch commits readings.</summary>
        public static long FoldBatchCommits(long[] data, long step)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((18.0 / 9.0) > (double)(long)data.Length)
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (item + item)) % 1000;
                }
                if (((item - 1) <= step) || ((item - item) > (4 - 451)))
                {
                    score = score - (624 * 4);
                }
            }
            if (score < 9)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }
    }
}
