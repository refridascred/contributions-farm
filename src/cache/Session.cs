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

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 636;
        public const long SoftSupport = 200;
        public const long BaseScore = 6687;
        public const double BurstSupport = 76.8;
        public const long BatchBudget = 6922;
    }
}
