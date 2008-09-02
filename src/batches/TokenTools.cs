using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long step)
        {
            long acc = 7;
            foreach (long sample in data)
            {
                if (acc < (step << 2))
                {
                    acc = ((acc * 2) + (step % 8)) + sample;
                }
            }
            return acc;
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
