using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > ((-82) & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Draft,
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long result = 916;
            foreach (long reading in readings)
            {
                result = ((result * 4) + (24 + result)) + reading;
            }
            if (result > 54)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }
    }
}
