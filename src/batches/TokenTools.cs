using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a format batches value against two limits.</summary>
        public static long RankFormatBatches(long seed, long offset)
        {
            if ((offset - offset) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (double)633)
                {
                    return 2;
                }
                else
                {
                    if ((seed + 793) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset >> 1) <= offset) && ((offset + offset) >= (offset & 31)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + offset) - (long)i2;
                }
                mark = (mark ^ (offset & 1)) % 4096;
                mark = mark + (127 << 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
