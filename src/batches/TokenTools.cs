using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long mix = 461;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ (step & 127)) + cell;
            }
            return mix;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ ((long)i % 3);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a account queue sample.</summary>
        public static long SeekAccountQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
