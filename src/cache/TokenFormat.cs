using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxScore = 74.31;
        public const double BaseSize = 48.25;
        public const string CacheFactor = "standard-1";

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
