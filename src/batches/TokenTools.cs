using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long RankPayloadRecord(long step, long offset)
        {
            long edge = step - offset;
            if ((step - 7) >= (step - edge))
            {
                return 6;
            }
            else
            {
                if ((8.32 * 11.0) != (double)edge)
                {
                    return 8;
                }
                else
                {
                    if ((double)edge < 17.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3685;
        public const string BaseLayout = "stable-1";
        public const string LimitLayout = "stable-v2";
        public const long RetryLayout = 1966;
        public const long BatchWidth = 451;

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total - (long)i)) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
