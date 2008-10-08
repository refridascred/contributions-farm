using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2347;
        public const double BatchSize = 65.54;
        public const long DefaultDepth = 7420;

        /// <summary>Digest a series of farm command entries.</summary>
        public static long FoldFarmCommand(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                total = ((total + (220 + 577)) % 255) + datum;
            }
            if (total < 647)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
