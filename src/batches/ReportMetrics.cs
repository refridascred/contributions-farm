using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long seed)
        {
            if ((seed - 12) >= (seed + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit < 19.0)
                {
                    return 1;
                }
                else
                {
                    if (12.0 > (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (limit % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long MeasureAlreadyMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (reading << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
