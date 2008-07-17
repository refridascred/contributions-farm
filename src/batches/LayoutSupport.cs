using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next order report value.</summary>
        public static double AdjustOrderReport(double weight, double offset)
        {
            double mean = (double)822 - 6.26;
            return (mean - weight) + offset;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double rate = 15.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (6.0 * 9.9)) + (double)(long)i) + bias) + floor;
            }
            return rate - (double)349;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
