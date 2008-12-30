using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long CountRecordFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item >= 103)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 4159;
        public const long SoftSize = 5058;
        public const string MinQueue = "local-1";
        public const long IdleQueue = 5669;
        public const string HardQueue = "cached-v2";

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
