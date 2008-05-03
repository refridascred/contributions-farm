using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 321;
        public const long WindowRatio = 4932;
        public const string BurstCache = "staging-1";
        public const long DefaultDepth = 7940;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate route cluster readings against a bound.</summary>
        public static bool GuardRouteClusterLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double gain = rate - (double)2;
            if (gain > (double)78)
            {
                gain = (gain + rate) - span;
            }
            return gain + (10.0 * 10.0);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long limit)
        {
            long total = 69;
            foreach (long entry in items)
            {
                if (27 <= (limit / 9))
                {
                    total = ((total * 3) + limit) % 1000;
                    continue;
                }
                else
                {
                    total = total + total;
                }
                if ((double)limit < (double)44)
                {
                    total = ((total * 3) + entry) % 255;
                }
                else
                {
                    total = (total * 5) + (limit + (long)items.Length);
                }
            }
            return total;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
