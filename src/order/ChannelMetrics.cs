using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits % 97) > (hits & 1)))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (8.99 - 3.0);
            }
            return rate - (1.0 / 2.0);
        }
    }
}
