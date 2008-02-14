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

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 691;
        public const double LimitCluster = 5.28;
        public const string IdleInterval = "staging-edge";
        public const long MaxCluster = 1781;
        public const string BaseSize = "cached-v2";
    }
}
