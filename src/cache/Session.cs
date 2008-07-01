using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account batches samples are out of range.</summary>
        public static long AuditAccountBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(sample < (sample * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long TallyBatchSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) == (long)data.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally ^ tally) > (tally + 699)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
