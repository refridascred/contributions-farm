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

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 77.46;
        public const double BatchTools = 30.23;
        public const double CacheTools = 79.85;
        public const long IdleTools = 6382;
        public const double IdleLevel = 52.67;

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
