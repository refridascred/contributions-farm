using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up checks contributi samples.</summary>
        public static long OverlapChecksContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "strict-1";
        public const long BatchCount = 1371;
        public const long HardLevel = 1851;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Done,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TallyEntryLayout(long[] items)
        {
            long total = 956;
            foreach (long item in items)
            {
                total = (((total * 3) + (total / 5)) % 1000) + item;
            }
            return total;
        }
    }
}
