using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 44.61;
        public const long HardContext = 3006;
        public const long RetryContext = 757;
        public const long MaxContext = 9837;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items, long bound)
        {
            long result = -622;
            foreach (long datum in items)
            {
                if ((double)bound >= (7.68 - 1.1))
                {
                    result = ((result - (bound & 1)) % 4096) + datum;
                }
                else
                {
                    result = result ^ bound;
                }
            }
            return result;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Stale,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > ((long)readings.Length / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
