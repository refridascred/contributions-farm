using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum % 10) > 0)
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((23 + 86) <= matches)
                {
                    matches = ((matches + 1) + item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "legacy-1";
        public const long LimitSize = 837;
        public const long DefaultSpan = 1224;
        public const string IdleBudget = "alpha";
        public const long IdleStream = 2583;
    }
}
