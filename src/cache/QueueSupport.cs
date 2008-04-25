using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double drift = span;
            if (drift < (ratio + span))
            {
                drift = drift - (double)(-71);
            }
            return drift + ratio;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCount = 76.02;
        public const long SoftCount = 8671;
        public const long MaxCluster = 5859;
    }
}
