using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((step - sample) <= (sample + step)) && ((count % 24) == (385 + 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
