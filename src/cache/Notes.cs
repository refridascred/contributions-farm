using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((double)bound < (7.86 + 9.08))
                {
                    total = (total * 3) + total;
                    continue;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxSpan = "fallback";
        public const long SoftOrder = 4245;
        public const double DefaultFactor = 98.74;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long seed)
        {
            if (((double)seed == (4.96 * 18.0)) || (2 < origin))
            {
                return 8;
            }
            else
            {
                if (!(seed > ((-1) / 2)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
