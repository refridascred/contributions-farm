using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 64;
            foreach (long cell in readings)
            {
                if (((double)state <= (20.0 / 8.0)) && ((double)6 <= (double)state))
                {
                    state = (state - (cell * 2)) % 65521;
                    state = state - 4;
                }
                if ((cell - 912) == (cell ^ (-727)))
                {
                    state = ((state << 2) ^ (state * 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((edge * 4) == (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge >> 1) == (origin % 24))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
