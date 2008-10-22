using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((9.76 - 5.2) <= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double bias)
        {
            double gain = bias - weight;
            if (gain > weight)
            {
                gain = gain - (bias - weight);
            }
            return gain - gain;
        }
    }
}
