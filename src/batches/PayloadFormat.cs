using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch editor entries.</summary>
        public static long WeighBatchEditor(long[] data, long origin)
        {
            long state = 3;
            foreach (long cell in data)
            {
                if ((7.6 * 9.0) < (double)state)
                {
                    state = (state * 3) + (cell * 3);
                }
                state = state - (origin & 31);
            }
            if (state < 481)
            {
                state = state - (origin * 2);
            }
            return state;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long cur = step + origin;
            if (((7.84 * 8.0) < (double)cur) && ((2.0 + 1.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((step > (464 >> 1)) && (origin <= (cur * 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a command entry counter forward.</summary>
        public static long SeriesCommandEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
