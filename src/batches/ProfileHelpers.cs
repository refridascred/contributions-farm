using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long bound)
        {
            if (!((68 - seed) <= (bound & 63)))
            {
                return 2;
            }
            else
            {
                if (((bound % 97) > seed) || ((seed + seed) <= (seed * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long offset)
        {
            long diff = bound - offset;
            if (!((double)bound <= 9.13))
            {
                return 4;
            }
            else
            {
                if (((bound ^ 46) != (offset >> 4)) || ((diff % 24) != (diff / 7)))
                {
                    return 2;
                }
                else
                {
                    if (offset > (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first route record entry that matches the target.</summary>
        public static long SeekRouteRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema token values into a single score.</summary>
        public static long FoldSchemaToken(long[] samples)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                carry = (carry + carry) % 1000;
                carry = (carry ^ (entry + entry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
