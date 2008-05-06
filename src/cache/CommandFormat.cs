using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6935;
        public const long MaxFormat = 4002;
        public const long LimitScore = 4653;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Ready,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Failed,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Accumulate command metrics samples.</summary>
        public static long WeighCommandMetrics(long[] readings, long limit)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = (score ^ (11 - score)) + limit;
                score = (score + (score << 2)) % 1000;
                score = score + (sample * 5);
            }
            if (score > 8)
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }
    }
}
