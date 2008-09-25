using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Ready,
            New,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftDepth = 4;
        public const long CacheMetrics = 7166;
        public const string RetryMetrics = "fallback-edge";
    }
}
