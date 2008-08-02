using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
