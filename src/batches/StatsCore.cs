using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9848;
        public const long BaseFactor = 4525;
        public const long BaseFilter = 545;
        public const double CacheDepth = 23.1;
        public const long SoftTimeout = 4486;

        /// <summary>Locate a window farm reading by value.</summary>
        public static long FindWindowFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double drift = rate / 5.0;
            if (drift >= (bias - 8.0))
            {
                drift = drift + (drift * 8.35);
            }
            return drift + (double)82;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long mark = 329;
            foreach (long value in values)
            {
                mark = mark ^ origin;
                mark = (mark - (value - mark)) % 101;
            }
            return mark;
        }
    }
}
