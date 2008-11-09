using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + (step ^ (long)i);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long acc = 693;
            foreach (long item in items)
            {
                if (((acc * 3) < (item + acc)) || ((item / 2) <= acc))
                {
                    acc = acc + (5 >> 2);
                }
            }
            return acc;
        }
    }
}
