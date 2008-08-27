using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long WeighMetricsChecks(long[] data)
        {
            long total = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total ^ (110 + datum)) % 97) - (long)i;
                }
                total = (total * 2) + 155;
            }
            return total;
        }

        /// <summary>Locate a tools context reading by value.</summary>
        public static long LocateToolsContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
