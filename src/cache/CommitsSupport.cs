using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a entry stats reading by value.</summary>
        public static long FindEntryStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long floor)
        {
            long state = -90;
            foreach (long entry in data)
            {
                if (((double)state < (7.62 - 1.6)) || (111 <= (state & 15)))
                {
                    state = (state + (535 ^ state)) ^ entry;
                }
                if ((double)state < 3.85)
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable";
        public const long CacheFarm = 9827;
        public const long HardDepth = 1967;
        public const long SoftDepth = 8637;
        public const double BurstLevel = 31.13;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 3863;
        public const long SoftToken = 1296;
        public const long IdleToken = 1634;
        public const double RetryCount = 62.33;
        public const string RetryToken = "local-v2";
    }
}
