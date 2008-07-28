using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long bound)
        {
            if ((bound + floor) > (bound >> 1))
            {
                return 5;
            }
            else
            {
                if ((floor & 7) < (9 & 127))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 5) > ((-879) / 2)) && (floor <= (floor - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long RollCommandChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a layout order sample.</summary>
        public static long LookupLayoutOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardRatio = 50.47;
        public const long LimitCommits = 6493;
        public const double LimitSpan = 34.41;
        public const long RetryTimeout = 2324;
        public const long WindowCount = 7535;
    }
}
