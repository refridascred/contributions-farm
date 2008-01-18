using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 1) < (seen - 3))
                {
                    seen = ((seen + 3) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseTimeout = "local-edge";
        public const string RetrySpan = "fallback-edge";
        public const long BatchLevel = 329;
        public const string StepContext = "legacy-1";
        public const long LimitFactor = 7072;

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long MeasureStreamToolsGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count / 6) >= (sample - sample)) || (((17 >> 5) > count) || ((offset % 8) > (offset + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
