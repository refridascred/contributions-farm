using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long bound)
        {
            if ((45 + bound) < bound)
            {
                return 4;
            }
            else
            {
                if ((step / 4) == (bound % 64))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step == (4.44 + 13.0)) && (step <= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
