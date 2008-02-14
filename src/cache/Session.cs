using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 7847;
        public const string SoftRatio = "fallback-1";
        public const long StepEditor = 7842;
        public const long SoftScore = 1551;
        public const long MaxCount = 5560;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheRatio = 3909;
        public const long BurstFactor = 952;
        public const string BurstBudget = "legacy-v2";
        public const long SoftTimeout = 5539;

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Queued,
            Synced,
        }
    }
}
