using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches / 5) < (matches + reading))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long CombineGraphContext(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (result <= (result >> 3))
                {
                    result = ((result * 2) + sample) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 2608;
        public const long WindowCount = 514;
        public const double WindowCounter = 36.2;
        public const long DefaultLevel = 2594;
    }
}
