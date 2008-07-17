using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double load = (double)(9 - 2);
            return ((load - 4.3) + scale) + floor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (6.0 + 5.2)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate schema command readings against a bound.</summary>
        public static bool ValidateSchemaCommandLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
