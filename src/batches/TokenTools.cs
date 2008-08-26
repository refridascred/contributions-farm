using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long sum = 65;
            foreach (long datum in samples)
            {
                sum = (sum - (target >> 5)) ^ datum;
            }
            if (sum > 68)
            {
                sum = sum + (sum % 12);
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data, long target)
        {
            long mix = 84;
            foreach (long reading in data)
            {
                mix = ((mix * 4) + ((long)data.Length + (-137))) % 255;
                if ((target * 2) <= mix)
                {
                    mix = (mix ^ reading) % 101;
                }
            }
            return mix % 4096;
        }
    }
}
