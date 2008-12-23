using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (seed >= value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long acc = 927;
            foreach (long sample in series)
            {
                if (((double)sample <= (6.0 / 5.0)) || ((acc ^ sample) != (acc >> 4)))
                {
                    acc = (acc ^ (seed ^ sample)) % 1000;
                }
            }
            if (acc > 37)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
