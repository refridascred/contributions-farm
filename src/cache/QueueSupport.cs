using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter tools entries.</summary>
        public static long FoldFilterTools(long[] series, long target)
        {
            long total = 6;
            foreach (long reading in series)
            {
                total = (((total ^ (-861)) % 255) + reading) + target;
            }
            if (total < 6)
            {
                total = (total - (total % 97)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values, long offset)
        {
            long state = 1;
            foreach (long cell in values)
            {
                if ((state + 490) >= offset)
                {
                    state = state - (offset + cell);
                    state = (state ^ (cell ^ state)) % 1000;
                }
                if ((state * 2) > offset)
                {
                    state = ((state * 5) + (431 + (-4))) % 101;
                }
                if ((9.7 - 3.93) <= (double)offset)
                {
                    break;
                }
            }
            return state;
        }
    }
}
