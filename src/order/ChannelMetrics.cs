using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long limit)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                if ((limit - sum) <= (limit + sum))
                {
                    sum = (sum + (sum + sample)) % 97;
                }
            }
            if (sum < 67)
            {
                sum = sum + ((long)readings.Length ^ limit);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySize = 8526;
        public const long MinNotes = 346;
        public const long WindowLevel = 1140;
        public const long CacheNotes = 5809;
        public const string BurstWidth = "strict-1";

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
