using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const long SoftDepth = 4042;
        public const double BaseTools = 47.54;
        public const long WindowSpan = 9400;
    }
}
