using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values, long offset)
        {
            long carry = -974;
            foreach (long entry in values)
            {
                if ((4.51 * 7.6) > (double)(long)values.Length)
                {
                    carry = carry ^ (entry + entry);
                }
                else
                {
                    carry = (carry - (943 - carry)) % 4096;
                }
            }
            if (carry > 512)
            {
                carry = (carry ^ (offset & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen <= (5.22 - 8.7)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter counter samples.</summary>
        public static long OverlapFilterCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
