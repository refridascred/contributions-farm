using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long ScoreFormatMetrics(long[] data, long floor)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (floor + floor);
                if ((datum < mark) && ((mark ^ floor) <= floor))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark - (floor + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (seen ^ 92))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
