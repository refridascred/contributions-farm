using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long CountChannelMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) != (sample * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long carry = -95;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (2 & 15)) % 255;
                carry = ((carry * 4) + (sample - (-62))) % 101;
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
