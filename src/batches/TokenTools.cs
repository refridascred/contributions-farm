using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Closed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of tools profile readings.</summary>
        public static long CombineToolsProfile(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (((carry ^ (carry ^ carry)) % 97) + cell) - bound;
            }
            return carry;
        }
    }
}
