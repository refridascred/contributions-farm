using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 9494;
        public const string WindowSpan = "stable-v2";
        public const string RetryScore = "cached";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items, long limit)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                if (mark >= (mark - mark))
                {
                    mark = (((mark << 3) ^ (mark & 127)) % 101) ^ sample;
                }
                mark = (mark - ((-752) & 7)) % 101;
            }
            if (mark < 29)
            {
                mark = ((mark * 3) + (limit - limit)) % 255;
            }
            return mark;
        }
    }
}
