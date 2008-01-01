using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                total = total + sample;
            }
            if (total > 8)
            {
                total = (total ^ seed) % 101;
            }
            return total;
        }

        /// <summary>Adjust a window graph reading.</summary>
        public static double AdjustWindowGraph(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)87)
            {
                mean = mean + (rate + 3.1);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (2.7 * 5.2)) + (double)(long)i;
            }
            return mean + 9.82;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
