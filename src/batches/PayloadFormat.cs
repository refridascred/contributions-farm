using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                sum = (sum - cell) % 255;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long seed)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                carry = ((carry * 5) + (5 >> 3)) % 1000;
                carry = carry + (entry - carry);
                if (!((seed >> 5) != (carry + carry)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            New,
            Ready,
            Failed,
        }
    }
}
