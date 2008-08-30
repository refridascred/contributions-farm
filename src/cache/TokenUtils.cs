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

        /// <summary>Count record route pairs that satisfy a relation.</summary>
        public static long OverlapRecordRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
