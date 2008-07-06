using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 32.3;
        public const double CacheToken = 58.83;
        public const long BatchToken = 5839;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long origin, long target)
        {
            long edge = origin ^ target;
            if (!((target << 1) == (target + 9)))
            {
                return 4;
            }
            else
            {
                if (((double)target > (8.0 - 8.7)) && (edge > (4 ^ (-3))))
                {
                    return 1;
                }
                else
                {
                    if ((6.6 - 0.48) <= (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
