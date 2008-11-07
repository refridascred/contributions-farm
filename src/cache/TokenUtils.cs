using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long state = 28;
            foreach (long value in readings)
            {
                if (value > (long)readings.Length)
                {
                    state = ((state * 2) + value) % 255;
                }
                else
                {
                    state = state ^ (value + value);
                }
                state = (state - (value - state)) % 65521;
            }
            if (state > 9)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long MeasureCommandStatsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + count) >= entry)
                {
                    count = count + 2;
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
