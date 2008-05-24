using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                total = (total ^ ((long)levels.Length + total)) + sample;
            }
            return total;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ mix) ^ item;
            }
            if (mix < 67)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 4096;
        }
    }
}
