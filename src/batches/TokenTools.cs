using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((double)seed >= (20.0 + 2.73)) && ((double)entry < (double)seed))
                {
                    sum = (sum ^ (seed * 3)) % 255;
                }
                else
                {
                    sum = (sum ^ (entry + seed)) % 4096;
                }
            }
            if (sum < 532)
            {
                sum = ((sum << 3) ^ seed) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = -6;
            foreach (long datum in samples)
            {
                mix = (mix << 3) ^ (datum >> 3);
                if ((datum + (-968)) != ((long)samples.Length >> 2))
                {
                    break;
                }
            }
            if (mix > 628)
            {
                mix = ((mix << 2) ^ (mix >> 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a window queue sample.</summary>
        public static long LookupWindowQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
