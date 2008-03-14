using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of githubfarm stream readings.</summary>
        public static long DigestGithubfarmStream(long[] levels)
        {
            long carry = 179;
            foreach (long sample in levels)
            {
                carry = ((carry << 3) ^ carry) + sample;
            }
            if (carry < 713)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "stable";
        public const long HardWidth = 1686;
        public const long BaseToken = 8170;
        public const string BaseScore = "open-edge";
    }
}
