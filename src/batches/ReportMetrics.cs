using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 503;
            foreach (long datum in levels)
            {
                if ((datum % 16) < (datum + total))
                {
                    total = (total + datum) % 4096;
                }
            }
            if (total < 6)
            {
                total = (total + (total >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long seed)
        {
            if (((97 * 4) == (seed + 426)) && (((-7) - target) == (target + seed)))
            {
                return 6;
            }
            else
            {
                if ((target - seed) < target)
                {
                    return 3;
                }
                else
                {
                    if (((seed & 127) < target) && ((7.2 / 9.0) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Queued,
            Ready,
            Idle,
            Stale,
        }
    }
}
