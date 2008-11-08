using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryWidth = 25.22;
        public const long DefaultEditor = 5739;
        public const string MaxDepth = "primary-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftSpan = 3967;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long mark = 99;
            foreach (long reading in readings)
            {
                mark = (mark - reading) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
