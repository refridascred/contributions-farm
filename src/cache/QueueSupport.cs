using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((-9) & 31) == (seen + origin))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels)
        {
            long result = 3;
            foreach (long reading in levels)
            {
                if ((result % 16) == (result - result))
                {
                    result = (result ^ (result % 16)) + reading;
                }
            }
            if (result > (-415))
            {
                result = result - (result * 2);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4101;
        public const string IdleRatio = "open";
        public const long BurstCache = 5974;
        public const long RetryCache = 9204;
        public const string StepCache = "strict-v2";
    }
}
