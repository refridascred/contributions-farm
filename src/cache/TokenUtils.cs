using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long ScoreRouteSession(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading / 2) < reading)
                {
                    anchor = anchor ^ (reading - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((4.76 - 5.52) <= (double)count)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
