using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double drift = floor + (ratio + 9.7);
            if (drift < drift)
            {
                drift = drift - ratio;
            }
            return drift - (drift - floor);
        }

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
