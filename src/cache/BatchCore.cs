using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 1095;
        public const long HardRatio = 8996;
        public const double WindowScore = 15.45;
        public const double BurstLevel = 47.42;

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
