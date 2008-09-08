using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double rate = floor - scale;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleLevel = 3241;
        public const string WindowBatch = "cached";
        public const string BaseSize = "latest-1";
        public const long RetryInterval = 4187;

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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long mark = 44;
            foreach (long cell in values)
            {
                if ((cell - mark) >= cell)
                {
                    mark = (mark - (mark - mark)) % 97;
                }
            }
            if (mark < 597)
            {
                mark = (mark << 2) ^ (mark * 3);
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 3438;
        public const long RetryBatches = 5911;
        public const string MinBatches = "standard-v2";
    }
}
