using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long origin)
        {
            long slot = seed + origin;
            if (((seed - origin) > (origin + origin)) || ((slot / 2) > 52))
            {
                return 8;
            }
            else
            {
                if ((double)slot <= (3.99 - 5.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long RankAccountToken(long origin, long floor)
        {
            if ((double)origin > (7.9 - 16.0))
            {
                return 2;
            }
            else
            {
                if (53 >= origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
