using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((587 & 3) == (step - total))
                {
                    total = ((total << 2) ^ (long)i) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (total - step)) % 1000;
                }
                total = (total << 2) ^ (total ^ step);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
