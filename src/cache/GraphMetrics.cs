using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits >> 5) < (hits >> 4)))
                {
                    hits = ((hits + 1) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long AuditAccountWindowHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) <= (14 + count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double scale = (double)(307 ^ (-5));
            if (scale > 0.64)
            {
                scale = scale + (weight - weight);
            }
            else
            {
                scale = scale - (scale * 7.02);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale - offset)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
