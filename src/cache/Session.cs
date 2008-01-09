using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series, long floor)
        {
            long total = 7;
            foreach (long item in series)
            {
                if ((5.6 / 5.0) != (double)total)
                {
                    total = (((total ^ total) % 97) + item) + floor;
                }
            }
            return total % 97;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long MeasureTokenOrderGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + target) >= (target << 3)) || ((8.84 + 8.0) >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 2) + (step * 2)) ^ (long)i2;
                }
                if ((4.62 - 2.3) == (double)step)
                {
                    result = (result ^ (result + step)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
