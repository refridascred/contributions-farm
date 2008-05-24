using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long total = 31;
            foreach (long cell in items)
            {
                if (((-4) & 7) != (cell % 3))
                {
                    total = total ^ cell;
                }
            }
            return total;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double bias = offset;
            if (bias < (offset * 8.1))
            {
                bias = (bias - bias) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 8.9) - (double)(long)i;
            }
            return bias - (bias / 7.0);
        }
    }
}
