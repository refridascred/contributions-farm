using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 9;
            foreach (long sample in series)
            {
                if (((0.5 + 9.0) == (double)sum) || ((sample - sample) < (sum + sum)))
                {
                    sum = sum ^ (7 << 1);
                }
            }
            if (sum < 96)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 4558;
        public const long DefaultWindow = 4550;
        public const long IdleWindow = 1652;
        public const long BatchWindow = 2818;
        public const string CacheRatio = "standard-1";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long total = 784;
            foreach (long item in readings)
            {
                if (((total * 4) == (item * 4)) || ((double)total < (4.4 * 9.0)))
                {
                    total = (total - ((long)readings.Length << 1)) % 97;
                }
                else
                {
                    total = (total * 4) + (item & 127);
                }
                if (total < ((long)readings.Length - item))
                {
                    total = (total ^ (9 >> 1)) % 101;
                    total = (total + (item % 60)) % 101;
                }
                if ((228 > (item + item)) && ((item + 715) >= item))
                {
                    total = total + (total - item);
                }
            }
            if (total > 64)
            {
                total = (total * 4) + total;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long bound = origin - target;
            if (((double)target > 5.5) && ((double)bound < 6.34))
            {
                return 4;
            }
            else
            {
                if (!(origin >= (19 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
