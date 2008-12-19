using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the already account series from a seed.</summary>
        public static long SeriesAlreadyAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor + ((long)i + offset);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the token entry series from a seed.</summary>
        public static long IterateTokenEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i ^ bound) == (result ^ bound))
                {
                    result = (result + result) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
