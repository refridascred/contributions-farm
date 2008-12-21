using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (20.0 <= (double)mark)
                {
                    mark = (mark ^ (seed + mark)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
