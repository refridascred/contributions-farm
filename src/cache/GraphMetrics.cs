using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two command queue measurements.</summary>
        public static double ProjectCommandQueue(double scale, double span)
        {
            double scale2 = (4.8 / 6.0) / 3.0;
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - span;
            }
            else
            {
                scale2 = scale2 - (6.2 * 6.6);
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double ratio = 3.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) - weight) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long AuditCommitsRecordHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((double)datum > (9.04 / 9.0)) || !((double)floor <= (4.2 + 19.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
