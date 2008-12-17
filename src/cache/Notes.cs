using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report queue value against two limits.</summary>
        public static long BucketReportQueue(long limit, long target)
        {
            long cur = limit - target;
            if (14.0 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((cur + target) != (72 - cur))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long BatchWindow = 2033;
        public const long DefaultCount = 9105;
        public const string WindowLevel = "staging";

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7615;
        public const double MinAlready = 21.71;
        public const long BaseCount = 5093;
        public const string StepAlready = "open";

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
