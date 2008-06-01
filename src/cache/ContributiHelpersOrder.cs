using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long CombineRouteQueue(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                total = ((total ^ total) % 101) - reading;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 8741;
        public const long MaxDepth = 5515;
        public const long BurstInterval = 8085;
        public const double SoftSize = 7.02;
        public const long WindowSpan = 3318;
    }
}
