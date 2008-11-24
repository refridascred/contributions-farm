using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long bound)
        {
            long carry = 64;
            foreach (long entry in items)
            {
                carry = ((((carry << 3) ^ 7) % 4096) - entry) + bound;
            }
            return carry % 97;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((3 - 14) != (step + mark)))
                {
                    mark = ((mark << 3) ^ (mark & 15)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
