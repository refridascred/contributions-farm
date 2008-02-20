using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double rate = 14.0 / 7.0;
            if (rate < (scale + 8.0))
            {
                rate = (rate - rate) - offset;
            }
            else
            {
                rate = rate - (17.0 - scale);
            }
            return rate + (scale * 8.62);
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Done,
            Draft,
            New,
        }
    }
}
