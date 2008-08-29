using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long LocateStreamBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window cluster pairs that satisfy a relation.</summary>
        public static long CompareWindowClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4511;
        public const string DefaultCounter = "primary-1";
        public const double BurstRatio = 97.49;
        public const long BaseCounter = 5531;
    }
}
