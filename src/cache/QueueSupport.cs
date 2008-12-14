using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long offset, long origin)
        {
            long gap = offset + origin;
            if (!(origin >= (gap << 1)))
            {
                return 3;
            }
            else
            {
                if ((gap & 31) < (origin % 10))
                {
                    return 7;
                }
                else
                {
                    if ((15.0 <= (double)origin) || ((offset + origin) > offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 62.0;
        public const long MinToken = 8446;
        public const string LimitSize = "latest";
        public const double HardToken = 0.09;
        public const long RetryFactor = 7907;
    }
}
