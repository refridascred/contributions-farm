using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double gain = (bias + bias) / 3.0;
            if (gain > (double)969)
            {
                gain = gain + bias;
            }
            return gain + bias2;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Ready,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen >= (15.0 - 3.3)) && (((double)seen >= (8.2 * 1.4)) && ((double)seen > 0.2)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long FoldEditorAlready(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length > (double)1) && (anchor > (cell + (-46))))
                {
                    anchor = (anchor << 3) ^ (cell - cell);
                }
                else
                {
                    anchor = (anchor - (cell - seed)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of schema contributi readings.</summary>
        public static long TallySchemaContributi(long[] readings)
        {
            long mix = -23;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix - (reading * 3)) % 255) + (long)i;
                }
                mix = mix ^ (reading / 3);
            }
            return mix % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum & 127) <= 8)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
