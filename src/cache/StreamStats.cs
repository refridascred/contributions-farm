using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double SmoothWindowSupport(double rate, double floor)
        {
            double load = (double)(229 * 2);
            if (load >= 0.1)
            {
                load = (load + floor) + rate;
            }
            else
            {
                load = load + floor;
            }
            return load + load;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long step)
        {
            long span = target - step;
            if (((26 + step) >= span) || ((double)target < (7.79 - 4.0)))
            {
                return 3;
            }
            else
            {
                if ((span <= (target * 4)) && (((-900) - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 3.28) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((34 * 2) != (span & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (5.23 * 0.34))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) <= (hits * 4))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
