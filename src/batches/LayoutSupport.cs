using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long origin)
        {
            if ((4 >> 3) == (origin >> 4))
            {
                return 0;
            }
            else
            {
                if ((2.64 - 3.51) < (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 4511;
        public const string StepSession = "open-1";
        public const long StepTimeout = 1568;
        public const long BurstSession = 3394;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long origin)
        {
            long edge = seed ^ origin;
            if (2 > (origin % 100))
            {
                return 6;
            }
            else
            {
                if (!(seed <= (edge ^ 35)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (5.52 + 1.17))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
