using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
