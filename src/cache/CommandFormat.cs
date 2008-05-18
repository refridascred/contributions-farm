using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "latest-1";
        public const long LimitPayload = 3421;
        public const long MaxSize = 8329;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if ((seed + seed) == (seed / 6))
            {
                return 5;
            }
            else
            {
                if ((seed >= (limit * 3)) || ((3 % 97) == (seed + 501)))
                {
                    return 2;
                }
                else
                {
                    if (2 > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Active,
            New,
            Queued,
            Dropped,
        }
    }
}
