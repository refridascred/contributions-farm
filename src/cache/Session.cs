using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long DigestGithubfarmReport(long[] samples, long origin)
        {
            long carry = -273;
            foreach (long entry in samples)
            {
                carry = (carry - (entry + 32)) % 65521;
            }
            if (carry < 98)
            {
                carry = ((carry * 3) + (origin + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (seed - (long)i)) % 97;
                if (carry >= (seed + carry))
                {
                    carry = (carry ^ carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

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
