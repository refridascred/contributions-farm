using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Idle,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 4677;
        public const long MaxCommits = 3676;
        public const long StepCommits = 1726;
        public const long StepSpan = 1324;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 7431;
        public const double DefaultStats = 46.8;
        public const double MaxSize = 68.44;
        public const double HardStats = 37.28;
        public const string BaseStats = "primary-v2";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count < (2.46 + 7.72))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
