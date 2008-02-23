using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (!(mark > (mark & 127)))
                {
                    mark = ((mark ^ (933 / 5)) % 255) - value;
                }
            }
            return mark % 4096;
        }
    }
}
