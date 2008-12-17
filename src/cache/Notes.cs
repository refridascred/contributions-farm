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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long total = 509;
            foreach (long value in samples)
            {
                if (355 >= value)
                {
                    continue;
                }
                if ((8.0 + 0.73) != (double)value)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
