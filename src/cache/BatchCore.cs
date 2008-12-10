using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading + origin)) && ((6.5 - 20.0) > (double)origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 97.79;
        public const double BurstInterval = 91.18;
        public const long BaseCount = 53;
        public const double BatchBudget = 88.02;
        public const long MinContext = 542;

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
