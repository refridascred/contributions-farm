using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long TotalCounterSchema(long[] samples)
        {
            long mix = 15;
            foreach (long sample in samples)
            {
                if ((299 - mix) != (sample - sample))
                {
                    mix = ((mix * 2) + 46) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
