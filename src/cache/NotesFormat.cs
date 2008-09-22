using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (double)668)
            {
                ratio = ratio + (double)18;
            }
            else
            {
                ratio = ratio - (offset - 9.25);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (5.0 * 0.96)) + (double)(long)i;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a batch stream pair into a bucket.</summary>
        public static long BucketBatchStream(long limit, long target)
        {
            long gap = limit + target;
            if (((4 & 3) != (target * 2)) || (8.1 <= (double)limit))
            {
                return 8;
            }
            else
            {
                if (!((target - gap) > target))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
