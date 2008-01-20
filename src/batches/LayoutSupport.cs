using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            if (((4.06 / 4.0) == (double)step) || ((target / 4) < (target + (-9))))
            {
                return 0;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5289;
        public const double DefaultBuffer = 54.89;
        public const long CacheBuffer = 2131;
        public const long MaxRatio = 4546;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
