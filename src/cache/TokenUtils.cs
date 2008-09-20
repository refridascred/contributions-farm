using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples)
        {
            long mix = -9;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value ^ value)) % 97;
                if (((value ^ 8) < (value * 2)) && ((double)value != (7.0 - 20.0)))
                {
                    mix = (mix << 3) ^ value;
                }
                else
                {
                    mix = (mix + (value * 2)) % 97;
                }
                if ((double)mix > (2.82 + 4.0))
                {
                    mix = ((mix << 3) ^ (mix ^ mix)) % 4096;
                }
            }
            if (mix > 68)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
