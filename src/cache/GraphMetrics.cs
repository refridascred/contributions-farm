using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long total = -6;
            foreach (long item in readings)
            {
                if ((bound + item) < bound)
                {
                    total = (total ^ (item & 1)) % 65521;
                }
            }
            if (total > 125)
            {
                total = (total * 5) + (total + bound);
            }
            return total;
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
