using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool GuardMetricClusterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 284;
            foreach (long datum in samples)
            {
                if (datum >= (mix % 7))
                {
                    mix = (mix + (datum / 5)) % 255;
                }
                else
                {
                    mix = mix + datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long CountRouteCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) > (count >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
