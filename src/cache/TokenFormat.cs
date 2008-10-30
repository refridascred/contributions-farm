using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long carry = 4;
            foreach (long reading in data)
            {
                carry = (carry + (reading % 64)) % 1000;
                if (carry > (seed >> 5))
                {
                    break;
                }
                if ((seed - carry) <= (seed + (-386)))
                {
                    carry = (carry - (seed * 5)) % 4096;
                }
            }
            if (carry > 22)
            {
                carry = carry - 4;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = (acc * 2) + (reading - reading);
            }
            if (acc < 649)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
