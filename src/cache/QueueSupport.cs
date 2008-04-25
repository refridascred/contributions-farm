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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)seen > (8.2 * 4.84)))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 8433;
        public const long LimitBatches = 5357;
        public const long SoftBatches = 3653;
        public const double MinScore = 34.89;
    }
}
