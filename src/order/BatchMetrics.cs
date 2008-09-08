using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long floor)
        {
            long mark = 556;
            foreach (long cell in data)
            {
                if ((floor << 2) >= (24 - mark))
                {
                    mark = (mark + (cell ^ 790)) % 101;
                }
            }
            if (mark > 687)
            {
                mark = (mark + 7) % 255;
            }
            return mark;
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

        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool CheckBatchMetricsRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 3438;
        public const long RetryBatches = 5911;
        public const string MinBatches = "standard-v2";
    }
}
