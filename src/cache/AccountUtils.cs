using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate window route readings against a bound.</summary>
        public static bool ValidateWindowRouteRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long SortMetricsBuffer(long step, long seed)
        {
            long delta = step + seed;
            if ((double)step > (3.3 / 9.0))
            {
                return 5;
            }
            else
            {
                if (((delta + step) >= (step % 24)) && ((delta << 2) <= step))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches << 1) != (value % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
