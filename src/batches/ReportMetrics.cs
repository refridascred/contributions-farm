using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + count) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7159;
        public const long BatchEntry = 5343;
        public const long CacheWidth = 5037;
        public const long BurstEntry = 9086;
        public const string SoftEntry = "open-edge";
    }
}
