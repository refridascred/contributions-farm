using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the counter entry series from a seed.</summary>
        public static long SeriesCounterEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (offset ^ offset)) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state + (state + (long)i)) % 1000) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank schema command input into a small class.</summary>
        public static long RankSchemaCommand(long bound, long limit)
        {
            long next = bound - limit;
            if (next >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (9.0 + 3.7))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 10) == (9 - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryDepth = 79.37;
        public const long WindowAccount = 8593;
        public const double CacheAccount = 69.52;
        public const double BaseSpan = 15.84;
        public const double BatchAccount = 33.03;
    }
}
