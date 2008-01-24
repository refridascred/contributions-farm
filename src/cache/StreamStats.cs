using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 2951;
        public const long LimitSpan = 6247;
        public const long MaxWidth = 4688;

        /// <summary>Rank account batch input into a small class.</summary>
        public static long GradeAccountBatch(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin - slot) == (slot + slot))
            {
                return 4;
            }
            else
            {
                if (((2.8 / 6.0) >= (double)origin) || ((origin / 4) > (origin >> 4)))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 6.1) < (double)seed)
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
}
