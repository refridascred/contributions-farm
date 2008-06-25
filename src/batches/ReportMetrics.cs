using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 9515;
        public const double BurstLevel = 55.0;
        public const string BatchContext = "open-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long seed)
        {
            long anchor = 5;
            foreach (long datum in values)
            {
                anchor = ((anchor + 886) + datum) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
