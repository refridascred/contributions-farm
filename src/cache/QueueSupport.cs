using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 95.54;
        public const long BatchFactor = 2459;
        public const long DefaultWidth = 1492;

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
