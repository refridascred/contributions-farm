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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
