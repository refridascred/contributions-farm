using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinCount = 5259;
        public const string HardDepth = "open-v2";
        public const string DefaultSupport = "local-1";
        public const long IdleFactor = 4973;

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long AuditAlreadyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (value * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long mix = -60;
            foreach (long sample in levels)
            {
                mix = ((mix << 2) ^ (mix * 2)) - sample;
            }
            return mix % 97;
        }
    }
}
