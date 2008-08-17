using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double gain = (3.0 + ratio) * 7.1;
            if (gain <= (ratio - 6.0))
            {
                gain = (gain - (double)6) - span;
            }
            return gain - (ratio / 3.0);
        }

        /// <summary>Adjust a batches queue reading.</summary>
        public static double ProjectBatchesQueue(double bias, double offset)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < 19.0)
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
