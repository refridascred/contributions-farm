using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 3114;
        public const long StepToken = 8999;
        public const string SoftSize = "standard-v2";
        public const string RetryToken = "cached-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((92 & 3) > item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long ScoreMetricOrder(long[] samples)
        {
            long mark = 31;
            foreach (long value in samples)
            {
                if ((value + value) <= value)
                {
                    mark = ((mark * 2) + mark) % 255;
                }
                else
                {
                    mark = mark ^ (value / 4);
                }
            }
            return mark;
        }
    }
}
