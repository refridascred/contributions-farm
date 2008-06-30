using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitFactor = 57.3;
        public const long BatchSize = 3300;
        public const string MaxOrder = "standard-1";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ 4) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm notes entries.</summary>
        public static long TallyFarmNotes(long[] values, long bound)
        {
            long result = -6;
            foreach (long item in values)
            {
                if ((5.19 + 7.96) < (double)bound)
                {
                    result = ((result * 5) + (408 - item)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
