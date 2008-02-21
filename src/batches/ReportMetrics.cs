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

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if (cell <= (cell >> 4))
                {
                    total = (total - (total << 3)) - origin;
                }
                if (total > (total * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
