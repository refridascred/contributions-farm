using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long offset)
        {
            long carry = 26;
            foreach (long reading in readings)
            {
                carry = ((carry << 2) ^ reading) % 65521;
                if ((double)reading == (8.6 - 6.35))
                {
                    carry = ((carry * 2) + (offset >> 3)) % 97;
                }
            }
            if (carry > 0)
            {
                carry = carry ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 9719;
        public const long WindowQueue = 5190;
        public const long HardQueue = 5829;
    }
}
