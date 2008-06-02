using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "stable-1";
        public const long BatchDepth = 5916;
        public const long MaxTools = 8799;

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long result = 317;
            foreach (long value in readings)
            {
                result = (result ^ (value * 5)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
