using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] samples, long limit)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                result = (((result << 2) ^ limit) % 255) + reading;
            }
            return result % 1000;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + limit)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
