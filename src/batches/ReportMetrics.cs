using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 3) + (60 / 7)) % 97) ^ (long)i2;
                }
                if (!((double)(long)i <= (16.0 * 9.32)))
                {
                    state = (state + state) % 97;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
