using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long seed)
        {
            if ((double)seed >= 3.61)
            {
                return 3;
            }
            else
            {
                if ((0.3 / 4.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((8.0 - 6.09) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
