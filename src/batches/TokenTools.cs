using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long mix = 170;
            foreach (long item in levels)
            {
                if ((12 + mix) != (mix - 4))
                {
                    mix = ((mix << 3) ^ (item + offset)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item >> 1)) % 4096;
                }
            }
            if (mix > (-519))
            {
                mix = (mix + (246 % 60)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
