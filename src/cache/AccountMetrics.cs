using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 9564;
        public const double MaxScore = 96.25;
        public const long LimitWidth = 1905;
        public const long RetryTools = 3945;
        public const long IdleTools = 8835;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 4) < (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback";
        public const double BaseScore = 52.11;
        public const long SoftCount = 5119;
        public const string StepDepth = "cached-1";
        public const long WindowScore = 5665;

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long carry = 875;
            foreach (long item in levels)
            {
                carry = ((carry * 2) + (896 * 2)) % 65521;
                carry = (carry - (item - carry)) % 4096;
                if (((item << 3) == (item >> 1)) && ((68 - item) == (item & 15)))
                {
                    carry = (carry + floor) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
