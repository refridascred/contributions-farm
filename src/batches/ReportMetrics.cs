using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings)
        {
            long result = -9;
            foreach (long reading in readings)
            {
                if ((6 ^ reading) <= (result * 2))
                {
                    result = result ^ (result + reading);
                }
                if ((845 / 6) < result)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result ^ (0 + result)) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
