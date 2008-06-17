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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total << 3);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
