using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double load = (double)(7 << 2);
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (floor * 2.7)) + (double)(long)i) + weight;
            }
            return load + (5.95 * 9.22);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (7 < (limit * 4))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double gain, double span)
        {
            double drift = 2.53;
            if (drift <= 1.9)
            {
                drift = (drift + (drift + drift)) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - (double)682;
        }
    }
}
