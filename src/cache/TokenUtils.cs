using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long TallyMetricsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
