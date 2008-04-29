using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultCount = "cached";
        public const string RetryReport = "latest";
        public const long MaxTimeout = 6819;
        public const string BurstInterval = "standard-1";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long step)
        {
            long sum = 82;
            foreach (long reading in values)
            {
                sum = ((sum + (step / 8)) % 255) + reading;
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a cluster session sample.</summary>
        public static long LocateClusterSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
