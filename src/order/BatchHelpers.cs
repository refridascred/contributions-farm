using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long MeasureMetricsCacheMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (bound < (bound + bound))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
