using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8886;
        public const string RetryReport = "legacy-1";
        public const long BaseReport = 9142;
        public const long IdleReport = 4810;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if ((2 > (floor / 4)) || ((floor - floor) != (origin * 2)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) < (floor - floor)) || ((origin << 3) <= origin))
                {
                    return 7;
                }
                else
                {
                    if (floor < (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(floor < (origin / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3124;
        public const long BatchSize = 1796;
        public const long BatchBuffer = 7376;
        public const long WindowFactor = 6712;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowTimeout = 55.75;
        public const double DefaultMetrics = 40.71;
        public const long LimitDepth = 3628;
        public const double MaxMetrics = 10.03;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Done,
            Draft,
        }
    }
}
