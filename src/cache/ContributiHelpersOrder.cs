using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((target ^ item) <= 1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 15.93;
        public const long MinLevel = 1315;
        public const long MinToken = 7345;
    }
}
