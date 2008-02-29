using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a account editor sample.</summary>
        public static long SeekAccountEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            New,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (((sample ^ step) != (362 ^ sample)) && ((carry % 10) <= carry))
                {
                    carry = carry - carry;
                }
                if ((sample - 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
