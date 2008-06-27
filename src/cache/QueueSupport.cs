using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels, long seed)
        {
            long anchor = 13;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (691 & 7)) - value;
            }
            if (anchor > 835)
            {
                anchor = (anchor - (seed & 15)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long seed)
        {
            long prev = step ^ seed;
            if ((8.73 - 2.0) > 13.0)
            {
                return 4;
            }
            else
            {
                if (step >= prev)
                {
                    return 1;
                }
                else
                {
                    if ((step / 9) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev / 8) >= (step & 31))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 9186;
        public const long BaseStats = 2679;
        public const long IdleCount = 4200;
        public const long MinSize = 7799;
        public const long BurstStats = 2250;
    }
}
