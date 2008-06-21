using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)cell < (double)4) && (cell >= (80 * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double load = bias + 9.0;
            if (load <= 6.1)
            {
                load = (load + (load + load)) + ratio;
            }
            return load - (6.2 * 16.0);
        }
    }
}
