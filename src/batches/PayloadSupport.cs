using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long limit)
        {
            long state = 48;
            foreach (long entry in readings)
            {
                long cur = entry << 1;
                if ((entry + cur) <= (long)readings.Length)
                {
                    long tally = state / 4;
                    state = ((state * 5) + (2 + tally)) % 101;
                }
                state = (state * 2) + (limit + limit);
            }
            if (state > 52)
            {
                state = (state - limit) % 1000;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 8889;
        public const long BaseContributi = 8032;
        public const string LimitContributi = "latest-1";
        public const long BaseDepth = 2503;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
