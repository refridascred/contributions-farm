using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count session queue pairs that satisfy a relation.</summary>
        public static long MatchSessionQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long bound2)
        {
            if ((60 - bound) > bound2)
            {
                return 3;
            }
            else
            {
                if ((double)(-8) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const double StepMetrics = 43.46;
        public const long DefaultTimeout = 1178;
        public const long LimitInterval = 1938;
    }
}
