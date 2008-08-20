using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 89.83;
        public const long IdleRatio = 5702;
        public const string LimitDepth = "primary-edge";

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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Dropped,
            Queued,
            Ready,
        }
    }
}
