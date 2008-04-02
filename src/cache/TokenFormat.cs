using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long FindMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Dropped,
            New,
            Paused,
        }
    }
}
