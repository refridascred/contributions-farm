using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((3 & 1) <= (datum & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + seen) >= origin)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double BlendGraphCluster(double gain, double bias)
        {
            double gain2 = (bias - 0.6) - bias;
            if (gain2 > (double)2)
            {
                gain2 = gain2 - 1.5;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (gain * 19.0);
        }
    }
}
