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

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long origin)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                if ((origin % 3) >= origin)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
                if ((135 <= (origin & 1)) && ((double)origin <= 1.1))
                {
                    sum = (sum << 2) ^ origin;
                }
                if ((double)cell > (8.26 / 9.0))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
