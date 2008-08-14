using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 202;
        public const long MinStream = 5732;
        public const string IdleCount = "standard-v2";
        public const long BurstStream = 1004;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
