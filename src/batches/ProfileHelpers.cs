using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long AuditCounterRouteOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (5.7 / 6.0))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Done,
            New,
            Ready,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double load = bias - bias;
            if (load >= (double)383)
            {
                load = (load + (bias - load)) + scale;
            }
            else
            {
                load = load + load;
            }
            return load - load;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 1613;
        public const double BurstBudget = 78.41;
        public const long CacheScore = 4039;

        /// <summary>Grade a profile contributi value against two limits.</summary>
        public static long BucketProfileContributi(long offset, long bound)
        {
            if (!((offset * 3) <= offset))
            {
                return 5;
            }
            else
            {
                if (!((offset & 3) != (bound ^ 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
