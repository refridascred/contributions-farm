using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((seed % 8) >= (bound / 8))
            {
                return 0;
            }
            else
            {
                if ((8.0 > (double)bound) || ((bound2 & 3) < bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
