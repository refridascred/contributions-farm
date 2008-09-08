using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((2.77 + 6.0) == (double)entry) || ((floor / 3) < (429 & 127)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a record stream reading.</summary>
        public static double BlendRecordStream(double scale, double span)
        {
            double mean = span;
            if (mean > (span + scale))
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5220;
        public const double RetryWidth = 78.98;
        public const long BaseTimeout = 8532;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 3438;
        public const long RetryBatches = 5911;
        public const string MinBatches = "standard-v2";
    }
}
