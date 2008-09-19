using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long carry = 58;
            foreach (long value in samples)
            {
                carry = ((carry - ((-329) * 4)) % 97) - value;
            }
            if (carry < 8)
            {
                carry = (carry - (carry & 7)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Idle,
            Pending,
        }
    }
}
