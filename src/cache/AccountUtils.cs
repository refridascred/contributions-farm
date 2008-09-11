using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache record readings.</summary>
        public static long DigestCacheRecord(long[] readings, long floor)
        {
            long carry = -96;
            foreach (long value in readings)
            {
                carry = ((carry ^ 0) - value) - floor;
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
