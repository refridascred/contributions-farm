using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7584;
        public const long HardFactor = 3818;
        public const long SoftTimeout = 7133;
        public const long BatchLevel = 220;
        public const string StepFormat = "cached-v2";

        /// <summary>Count checks filter pairs that satisfy a relation.</summary>
        public static long PairChecksFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm stats readings against a bound.</summary>
        public static bool GuardFarmStatsLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
