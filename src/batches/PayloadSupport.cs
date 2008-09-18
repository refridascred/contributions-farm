using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool ValidateBufferLayoutBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
