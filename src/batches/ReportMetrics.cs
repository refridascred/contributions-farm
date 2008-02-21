using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long total = 67;
            foreach (long datum in levels)
            {
                total = (total * 3) + total;
                if ((floor + floor) == (datum >> 2))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total << 3) ^ (total << 1);
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 27.93;
        public const long SoftFactor = 1570;
        public const string WindowDepth = "staging";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Pending,
            Queued,
        }
    }
}
