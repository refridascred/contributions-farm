using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series, long offset)
        {
            long carry = 151;
            foreach (long sample in series)
            {
                carry = (((carry - (carry << 3)) % 65521) ^ sample) + offset;
            }
            if (carry > 38)
            {
                carry = (carry ^ (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Failed,
            Queued,
        }
    }
}
