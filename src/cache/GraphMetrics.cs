using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (8.2 / 9.0)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 1619;
        public const long CacheStream = 8269;
        public const double WindowStream = 52.54;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 1247;
        public const long BurstPayload = 9354;
        public const long IdlePayload = 3317;
        public const string MaxDepth = "primary";

        /// <summary>Project the next batch filter value.</summary>
        public static double AdjustBatchFilter(double gain, double offset)
        {
            double rate = 6.9;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (gain / 6.0)) + (double)(long)i) + offset;
            }
            return rate - rate;
        }
    }
}
