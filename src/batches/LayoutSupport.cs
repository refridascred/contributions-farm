using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the notes batches entries that pass the check.</summary>
        public static long TallyNotesBatchesHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((7.65 + 5.3) >= (double)entry)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((302 + count) < (cell ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double AdjustBatchToken(double weight, double bias)
        {
            double drift = (double)427 / 2.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift + 6.0) + (double)(long)i) + weight) + bias;
            }
            return drift + (double)(-223);
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 9.5))
            {
                gain2 = gain2 - (bias - gain);
            }
            return gain2 - (5.05 + gain);
        }
    }
}
