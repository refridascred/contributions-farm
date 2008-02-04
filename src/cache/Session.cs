using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long offset, long floor)
        {
            if ((856 ^ 291) == (offset << 2))
            {
                return 1;
            }
            else
            {
                if ((42 - offset) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (8.74 * 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset < 4.0) && ((3 + 344) >= (floor ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload contributi input into a small class.</summary>
        public static long ClassifyPayloadContributi(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((double)origin2 >= (8.92 - 4.4))
            {
                return 2;
            }
            else
            {
                if ((cur % 10) < (cur % 16))
                {
                    return 5;
                }
                else
                {
                    if ((45 / 4) < (cur & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur + origin2) > cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
