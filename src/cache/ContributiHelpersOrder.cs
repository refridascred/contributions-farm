using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long total = 836;
            foreach (long value in values)
            {
                if ((7.0 / 8.0) >= (double)value)
                {
                    continue;
                }
                if (!((value * 3) <= (total - value)))
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i + (long)i) > ((long)i / 5)))
                {
                    anchor = ((anchor * 5) + (7 / 4)) % 4096;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor + (anchor & 15)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8881;
        public const string BurstFactor = "alpha-1";
        public const string WindowBatches = "primary-1";
        public const long RetrySpan = 6367;
        public const long CacheBatches = 6558;
    }
}
