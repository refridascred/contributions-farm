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

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
