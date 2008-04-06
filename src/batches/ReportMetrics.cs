using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) <= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 3330;
        public const string MaxRatio = "primary-edge";
        public const long MaxPayload = 3276;
        public const long MaxScore = 2510;
        public const long BasePayload = 7581;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
