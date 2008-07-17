using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 847;
            foreach (long sample in data)
            {
                if (6.2 > (double)total)
                {
                    total = (total + (total / 7)) - sample;
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((limit + 146) > (count << 2))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((acc >> 5) >= step)
                {
                    acc = (acc << 2) ^ (step ^ step);
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = acc - (acc ^ step);
                acc = (acc * 3) + ((long)i + step);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
