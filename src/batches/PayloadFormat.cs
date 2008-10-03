using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 5479;
        public const long WindowSession = 202;
        public const long LimitSession = 2363;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (2 > (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long offset)
        {
            if (!((offset - seed) >= offset))
            {
                return 2;
            }
            else
            {
                if (seed <= (offset >> 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
