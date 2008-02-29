using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a account editor sample.</summary>
        public static long SeekAccountEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long CombineGraphStats(long[] data)
        {
            long result = 85;
            foreach (long value in data)
            {
                if ((5 + value) >= value)
                {
                    result = (result - (value + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (((sample ^ step) != (362 ^ sample)) && ((carry % 10) <= carry))
                {
                    carry = carry - carry;
                }
                if ((sample - 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
