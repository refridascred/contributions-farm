using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long anchor = 1;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor << 2) ^ (261 & 7)) ^ (long)i;
                }
                anchor = ((anchor << 2) ^ (item % 12)) % 101;
                anchor = anchor + (item + item);
                if ((anchor >> 4) > 895)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 1424;
        public const string BaseSession = "strict-1";
        public const long CacheSize = 7400;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 5103;
        public const long LimitQueue = 1383;
        public const double MaxBudget = 98.39;
    }
}
