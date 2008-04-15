using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long carry = -924;
            foreach (long sample in samples)
            {
                if (!((carry % 60) > (sample << 1)))
                {
                    carry = ((carry + carry) % 4096) - target;
                }
                carry = (carry * 3) + 444;
            }
            return carry % 4096;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
