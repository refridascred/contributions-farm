using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "staging-v2";
        public const long CacheCount = 1045;
        public const double IdleLevel = 49.0;
    }
}
