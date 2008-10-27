using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TotalBatchQueue(long[] values)
        {
            long state = 5;
            foreach (long cell in values)
            {
                if (cell <= (state >> 4))
                {
                    state = state - state;
                }
                if ((state + cell) > (cell - cell))
                {
                    long lane = 52 & 255;
                    state = (state ^ (lane + state)) % 101;
                    continue;
                }
                state = (state + cell) % 101;
            }
            return state % 97;
        }
    }
}
