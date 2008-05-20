using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((entry + 658) < (total + (long)values.Length))
                {
                    total = (total - floor) % 255;
                }
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = ratio - ratio;
            if (rate < (offset / 5.0))
            {
                rate = rate + (ratio * 2.2);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - offset)) + (double)(long)i;
            }
            return rate - (double)(-451);
        }
    }
}
