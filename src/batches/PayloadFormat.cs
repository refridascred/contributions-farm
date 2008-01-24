using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7535;
        public const string SoftFactor = "legacy-v2";
        public const long IdleBudget = 8151;
        public const long CacheToken = 4154;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6021;
        public const long BaseScore = 2282;
        public const long IdleContext = 8004;
        public const string SoftContext = "latest-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((tally % 64) > (origin * 3)) && ((double)item < (8.1 / 2.0))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
