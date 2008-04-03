using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinSpan = 2.3;
        public const string BatchFactor = "strict-1";
        public const long IdlePayload = 1498;
        public const long BatchPayload = 9359;
        public const long IdleSpan = 1464;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((0 << 3) > (hits + hits)) || ((hits + datum) < datum)) && ((double)hits > (6.0 / 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
