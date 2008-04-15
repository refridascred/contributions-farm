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

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long CountContributiAlreadyHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + step) >= (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
