using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batch cache reading.</summary>
        public static double ScaleBatchCache(double gain, double bias)
        {
            double load = gain;
            if (load > (gain / 5.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - load;
            }
            return load + (double)1;
        }
    }
}
