using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Retry,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data)
        {
            long carry = 697;
            foreach (long reading in data)
            {
                carry = carry ^ (carry / 9);
                if (!((carry >> 3) > (reading & 15)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
