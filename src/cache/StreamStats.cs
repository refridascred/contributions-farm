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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((318 * 2) < (entry & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
