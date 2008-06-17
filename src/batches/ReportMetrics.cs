using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long delta = seed - bound;
            if (((bound + seed) <= delta) || ((delta + 894) <= (delta << 3)))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) >= seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of channel filter entries.</summary>
        public static long WeighChannelFilter(long[] levels)
        {
            long score = -51;
            foreach (long value in levels)
            {
                if (value < score)
                {
                    score = (score + score) % 255;
                }
            }
            return score;
        }
    }
}
