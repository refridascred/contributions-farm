using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepSpan = "legacy-v2";
        public const long DefaultStream = 3879;
        public const long IdleFactor = 5344;
        public const string BurstWidth = "stable-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long seed)
        {
            if ((double)seed == (6.0 - 2.75))
            {
                return 4;
            }
            else
            {
                if ((5 * 2) <= step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
