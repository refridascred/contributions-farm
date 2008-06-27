using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long origin2)
        {
            if ((origin & 63) < (origin << 1))
            {
                return 5;
            }
            else
            {
                if (((2 - origin) != (origin2 << 2)) && ((origin * 4) == (origin + origin2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin2 > (9.65 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.4 * 3.2) <= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
