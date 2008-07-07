using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 5153;
        public const double SoftFactor = 47.71;
        public const long MaxInterval = 3510;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long total = 14;
            foreach (long reading in readings)
            {
                total = (((total ^ (620 % 7)) % 1000) + reading) + seed;
                if ((6.25 * 9.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
