using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 78;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (result - result)) ^ reading;
            }
            return result % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) > seen)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool ValidateCacheOrderBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
