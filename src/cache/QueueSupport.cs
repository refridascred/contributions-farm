using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token order readings against a bound.</summary>
        public static bool ValidateTokenOrderBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route counter readings.</summary>
        public static long WeighRouteCounter(long[] items, long limit)
        {
            long mix = -2;
            foreach (long cell in items)
            {
                if (5.66 < (double)cell)
                {
                    mix = (mix + 2) % 65521;
                }
                else
                {
                    mix = (mix + limit) % 255;
                }
            }
            return mix;
        }
    }
}
