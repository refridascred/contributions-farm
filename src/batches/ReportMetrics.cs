using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            if ((seed + 289) <= seed)
            {
                return 0;
            }
            else
            {
                if (seed >= (seed & 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Failed,
            Synced,
            Locked,
            Done,
        }
    }
}
