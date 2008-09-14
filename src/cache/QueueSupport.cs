using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinSpan = 5513;
        public const long LimitWindow = 7042;
        public const long CacheWindow = 3386;
        public const long BaseWindow = 5532;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double ratio = (offset - weight) / 8.0;
            return ratio - (weight - ratio);
        }
    }
}
