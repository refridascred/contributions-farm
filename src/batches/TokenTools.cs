using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (target + 4)) % 255;
                if (((target - target) < mark) && ((714 >> 3) == ((long)i + mark)))
                {
                    mark = (mark ^ ((-1) - 312)) % 255;
                    continue;
                }
                if ((double)(long)i >= (7.51 * 7.5))
                {
                    mark = (mark << 3) ^ (652 >> 4);
                    mark = ((mark * 5) + (74 + mark)) % 101;
                }
                else
                {
                    mark = (mark - ((long)i % 7)) % 101;
                    mark = (mark ^ (mark + mark)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
