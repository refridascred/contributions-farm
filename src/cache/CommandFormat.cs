using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long carry = 281;
            foreach (long reading in data)
            {
                long bound = (carry / 6) & 7;
                if (!((reading - bound) == (carry - 94)))
                {
                    carry = (carry ^ (36 + bound)) % 4096;
                }
                if (!(((long)data.Length << 1) < (reading + reading)))
                {
                    carry = (carry << 2) ^ (reading * 4);
                }
                if (carry >= (3 + reading))
                {
                    break;
                }
            }
            if (carry < 12)
            {
                carry = (carry ^ (carry * 5)) % 97;
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
