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

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long floor)
        {
            if (((double)bound < (4.2 * 13.0)) && ((double)floor == (15.0 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.6 + 7.13))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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
