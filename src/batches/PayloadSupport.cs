using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 9590;
        public const string CacheLayout = "strict-v2";
        public const long BurstLayout = 1054;
        public const long MaxLayout = 9695;
        public const long RetryLayout = 193;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long step)
        {
            long span = origin + step;
            if ((span << 3) <= step)
            {
                return 1;
            }
            else
            {
                if (((-7) > span) || ((origin & 7) != (span - span)))
                {
                    return 8;
                }
                else
                {
                    if ((span % 3) > (91 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >> 3) >= origin)
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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(hits >= (hits >> 1)))
                {
                    hits = ((hits + 2) + sample) + limit;
                }
            }
            return hits;
        }
    }
}
