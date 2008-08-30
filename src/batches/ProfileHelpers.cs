using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
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
