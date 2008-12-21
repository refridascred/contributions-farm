using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((((long)items.Length + limit) > (cell << 2)) && ((hits - limit) >= hits)) && ((5.9 + 6.05) <= (double)limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long ScoreMetricChecks(long[] readings, long floor)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if (!((cell % 16) < (1 + cell)))
                {
                    result = result ^ (result / 2);
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (floor + floor)) % 1000;
            }
            return result % 97;
        }

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
