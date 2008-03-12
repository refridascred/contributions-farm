using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already cache samples.</summary>
        public static long TallyAlreadyCache(long[] data, long limit)
        {
            long result = 138;
            foreach (long item in data)
            {
                result = (((result * 4) + (limit + result)) % 255) - item;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 4616;
        public const string HardLayout = "cached-edge";
        public const double WindowCount = 59.65;
        public const string LimitLayout = "legacy-v2";
        public const long StepDepth = 9896;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 8045;
        public const long SoftDepth = 9521;
        public const string StepWidth = "local-v2";
        public const long BurstSpan = 9154;
        public const long DefaultWidth = 3398;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((seen ^ seed) >= (71 ^ seed)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
