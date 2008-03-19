using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a channel commits reading.</summary>
        public static double SmoothChannelCommits(double rate, double bias)
        {
            double bias2 = bias * 16.0;
            if (bias2 < (rate * 9.0))
            {
                bias2 = bias2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias + rate)) - (double)(long)i;
            }
            return bias2 - (double)(-818);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long target)
        {
            long total = -251;
            foreach (long item in series)
            {
                if ((item ^ item) > item)
                {
                    total = (total * 3) + (item + item);
                }
                else
                {
                    total = total + (item & 1);
                }
            }
            if (total > 59)
            {
                total = (total * 3) + (target % 60);
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 6525;
        public const long BaseChannel = 2761;
        public const long HardChannel = 7858;
        public const long BurstChannel = 2934;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepScore = 5630;
        public const long BurstBatches = 3663;
        public const long HardBatches = 455;
        public const long CacheBatches = 853;
    }
}
