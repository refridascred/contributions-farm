using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "alpha-edge";
        public const long IdleCount = 3570;
        public const double MinReport = 27.99;

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LocateOrderWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long limit)
        {
            long acc = 24;
            foreach (long item in samples)
            {
                if ((8.6 - 0.85) > (double)acc)
                {
                    acc = ((acc + ((long)samples.Length - item)) % 4096) + limit;
                }
            }
            return acc;
        }
    }
}
