using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long bound)
        {
            long score = 40;
            foreach (long value in samples)
            {
                if ((value + (long)samples.Length) != (bound + value))
                {
                    score = (score << 3) ^ (940 / 5);
                }
            }
            if (score > 573)
            {
                score = (score ^ (score / 7)) % 1000;
            }
            return score % 1000;
        }
    }
}
