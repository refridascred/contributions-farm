using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if ((value >> 4) == (mix ^ mix))
                {
                    mix = ((mix << 2) ^ (value >> 5)) % 1000;
                }
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double gain = (double)(0 + 2);
            if (gain >= (1.8 + floor))
            {
                gain = (gain + (floor * 0.5)) - weight;
            }
            return gain + (double)963;
        }
    }
}
