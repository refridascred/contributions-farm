using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepWidth = 3874;
        public const long SoftSupport = 9247;
        public const string BatchRatio = "local-1";
        public const long RetryCount = 5398;

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool ValidateReportCounterBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metric counter pairs that satisfy a relation.</summary>
        public static long MatchMetricCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double ProjectRouteChannel(double ratio, double floor)
        {
            double ratio2 = (double)((-78) + 701);
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            return ratio2 + (ratio2 / 2.0);
        }
    }
}
