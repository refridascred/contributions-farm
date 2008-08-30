using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8.2 - 9.0) <= (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long CombineStreamBatch(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (((double)state < (double)datum) && ((datum & 7) <= state))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = (state + (state ^ datum)) % 255;
                }
            }
            if (state > 6)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }
    }
}
