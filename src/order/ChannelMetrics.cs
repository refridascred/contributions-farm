using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series, long seed)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                carry = (carry + (31 + cell)) - seed;
                carry = carry - carry;
            }
            if (carry < 56)
            {
                carry = carry + (long)series.Length;
            }
            return carry % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (61 <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
