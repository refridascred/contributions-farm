using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long seed)
        {
            if (((double)seed == (6.0 / 3.0)) || ((step + seed) < step))
            {
                return 8;
            }
            else
            {
                if (step <= 53)
                {
                    return 0;
                }
                else
                {
                    if ((4 - seed) == (seed % 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 43.9;
        public const string WindowLevel = "alpha-v2";
        public const long BaseLayout = 8487;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long carry = -242;
            foreach (long cell in items)
            {
                if ((cell + cell) >= (carry + 87))
                {
                    carry = ((carry * 3) + (cell - cell)) % 101;
                }
            }
            if (carry > 54)
            {
                carry = ((carry << 3) ^ (909 * 3)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
