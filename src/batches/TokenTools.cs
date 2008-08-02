using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long mark = -87;
            foreach (long item in levels)
            {
                if (target >= mark)
                {
                    mark = (mark ^ (item % 7)) % 255;
                }
                else
                {
                    mark = (mark + (mark << 1)) % 101;
                }
            }
            if (mark < 20)
            {
                mark = mark - (mark - (long)levels.Length);
            }
            return mark % 65521;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
