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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < (91 >> 1))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 8433;
        public const long LimitBatches = 5357;
        public const long SoftBatches = 3653;
        public const double MinScore = 34.89;
    }
}
