using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinCount = 6256;
        public const double HardFormat = 0.58;
        public const long RetryCount = 1294;
        public const string IdleCount = "fallback-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            New,
            Ready,
            Paused,
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long CombineReportMetrics(long[] readings)
        {
            long total = 596;
            foreach (long datum in readings)
            {
                if ((double)total < (19.0 - 7.4))
                {
                    total = (total - (total << 2)) % 1000;
                }
                if ((double)datum == (double)total)
                {
                    total = total ^ (732 - total);
                }
            }
            if (total < 793)
            {
                total = ((total * 2) + (total ^ total)) % 1000;
            }
            return total;
        }
    }
}
