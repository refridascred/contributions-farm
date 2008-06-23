using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetrySize = 69.32;
        public const string HardSpan = "primary-edge";
        public const string WindowCount = "stable-edge";

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if (!((limit * 3) > (1 - 52)))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
