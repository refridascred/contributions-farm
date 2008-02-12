using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] samples)
        {
            long carry = -77;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (reading + carry)) % 97;
            }
            if (carry > 93)
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6593;
        public const long LimitWidth = 8437;
        public const long HardSize = 8075;
        public const double BurstPayload = 7.15;
        public const string WindowCount = "stable-v2";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits > 15.0)
                {
                    hits = ((hits + 1) + value) - floor;
                }
            }
            return hits;
        }
    }
}
