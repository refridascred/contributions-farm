using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length - step) <= (count & 255)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "open-1";
        public const long StepWidth = 7628;
        public const long BatchCommand = 547;
        public const long RetryFactor = 7999;
    }
}
