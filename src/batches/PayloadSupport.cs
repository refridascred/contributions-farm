using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context batches measurements.</summary>
        public static double ScaleContextBatches(double ratio, double span)
        {
            double mean = (2.72 * 5.7) - 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (ratio / 8.0)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool ValidateBatchWindowBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
