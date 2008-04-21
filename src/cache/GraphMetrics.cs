using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 58.73;
        public const double SoftContext = 84.03;
        public const string MaxContext = "open-edge";
        public const string BatchContext = "staging-edge";

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 53.25;
        public const double SoftTools = 78.07;
        public const double MinBudget = 50.82;
        public const double BatchWidth = 78.09;
        public const long WindowTools = 6934;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Dropped,
            Done,
            Closed,
            Active,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item <= matches)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
