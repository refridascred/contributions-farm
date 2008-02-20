using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepDepth = 96.65;
        public const string LimitLevel = "cached-edge";
        public const long RetryWidth = 842;
        public const long DefaultBudget = 5914;

        /// <summary>Validate already command readings against a bound.</summary>
        public static bool CheckAlreadyCommandLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (6.85 - 0.21))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
