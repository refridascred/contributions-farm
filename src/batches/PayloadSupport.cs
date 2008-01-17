using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 78;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ value) % 255;
                if (carry <= (value / 7))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 719;
        public const long RetrySize = 4465;
        public const double MinCommits = 20.41;
    }
}
