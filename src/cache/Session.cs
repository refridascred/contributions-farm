using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Pending,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = ((total - (target + target)) % 65521) ^ reading;
            }
            return total;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long ScoreMetricsStats(long[] levels, long floor)
        {
            long total = 736;
            foreach (long datum in levels)
            {
                total = (total - (floor + datum)) % 65521;
            }
            return total;
        }
    }
}
