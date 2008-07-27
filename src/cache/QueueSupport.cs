using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((4 + seen) >= seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi layout samples.</summary>
        public static long PairContributiLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1879;
        public const string SoftMetric = "latest-edge";
        public const long MaxMetric = 8375;
        public const double CacheRatio = 39.55;
    }
}
