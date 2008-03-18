using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((3.2 >= (double)origin) && (origin < (origin * 2)))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 97.26;
        public const long MaxSpan = 9346;
        public const string HardFactor = "cached-edge";
        public const double SoftSchema = 34.3;
        public const long StepBudget = 5624;
    }
}
