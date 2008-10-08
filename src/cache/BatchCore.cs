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

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series)
        {
            long state = 656;
            foreach (long datum in series)
            {
                if ((state + datum) > (8 - state))
                {
                    state = (state - 545) % 101;
                }
                if ((8 - datum) >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Retry,
            Done,
            Failed,
        }
    }
}
