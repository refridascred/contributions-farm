using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long total = 261;
            foreach (long datum in samples)
            {
                if (!((datum + 359) <= total))
                {
                    total = total + total;
                }
                total = ((total * 2) + (617 % 24)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 16.88;
        public const long BaseSize = 3771;
        public const string IdleToken = "cached-edge";
        public const string BatchDepth = "strict-edge";
        public const string MinToken = "strict-edge";
    }
}
