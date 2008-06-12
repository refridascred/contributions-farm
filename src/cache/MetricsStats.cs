using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long origin)
        {
            if (((-540) * 2) < origin)
            {
                return 0;
            }
            else
            {
                if (((target * 3) >= 2) || ((target ^ 5) != (origin >> 2)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools buffer entries that pass the check.</summary>
        public static long CountToolsBufferHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)matches < (double)7) || !((offset / 9) >= (reading + offset)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
