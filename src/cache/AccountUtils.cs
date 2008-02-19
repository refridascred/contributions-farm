using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((mix - mix) > mix)
                {
                    continue;
                }
                if (((123 * 3) <= item) && ((mix / 5) <= ((-4) + mix)))
                {
                    mix = (mix ^ (item / 8)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate metrics session samples.</summary>
        public static long ScoreMetricsSession(long[] levels, long offset)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (state + reading) + offset;
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items, long origin)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - (carry + (long)i)) % 4096;
                }
                if ((carry - origin) < cell)
                {
                    carry = (carry ^ (origin << 2)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
