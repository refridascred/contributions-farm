using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long mix = -32;
            foreach (long cell in series)
            {
                mix = (mix ^ (mix - cell)) % 65521;
                if ((7.63 / 3.0) <= (double)cell)
                {
                    mix = (mix ^ (98 >> 3)) % 255;
                }
                else
                {
                    mix = (mix - (cell + (long)series.Length)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 1260;
        public const string SoftWidth = "strict-1";
        public const string BurstBatches = "open-edge";
        public const long IdleDepth = 5921;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
