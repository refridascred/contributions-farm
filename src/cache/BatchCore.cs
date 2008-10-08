using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepScore = 2113;
        public const long DefaultFactor = 1374;
        public const long BurstSize = 2237;
        public const long DefaultLevel = 3374;
        public const long SoftDepth = 5383;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7580;
        public const string RetryTimeout = "fallback-1";
        public const string BaseInterval = "primary-edge";
        public const long IdleGraph = 5315;
    }
}
