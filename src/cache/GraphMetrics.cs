using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first batch cluster entry that matches the target.</summary>
        public static long SeekBatchClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 7698;
        public const string CacheFactor = "cached-edge";
        public const double MinScore = 60.67;
        public const long BurstStream = 1878;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)step >= (2.2 + 8.9))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
