using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (3.3 / 4.0)) + (double)(long)i) - span;
            }
            return gain + (double)96;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + hits) >= (hits << 1))
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
