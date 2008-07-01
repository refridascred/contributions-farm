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

        /// <summary>Accumulate checks window samples.</summary>
        public static long DigestChecksWindow(long[] readings, long floor)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                if ((floor - cell) < floor)
                {
                    carry = (carry + cell) % 101;
                }
            }
            return carry;
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
