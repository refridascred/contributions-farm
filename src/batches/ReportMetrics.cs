using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long result = 240;
            foreach (long entry in readings)
            {
                if (result <= (entry & 7))
                {
                    result = result + entry;
                }
                else
                {
                    result = (result ^ ((long)readings.Length % 5)) % 255;
                }
                if ((result - 906) < (result / 9))
                {
                    result = (result ^ (result >> 5)) % 65521;
                }
            }
            if (result < 36)
            {
                result = (result << 3) ^ 92;
            }
            return result % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
