using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long BurstEntry = 2732;
        public const long LimitSpan = 4515;
        public const long BatchEntry = 7008;
        public const double RetryScore = 25.63;

        /// <summary>Audit window stream readings against a rule.</summary>
        public static long AuditWindowStreamOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((seed << 3) <= count))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc ^ (acc % 60)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
