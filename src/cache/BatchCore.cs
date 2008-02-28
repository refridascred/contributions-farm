using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long score = 654;
            foreach (long datum in readings)
            {
                if ((4 >> 2) >= (score + datum))
                {
                    score = ((score * 2) + (datum - datum)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((5.0 * 8.0) <= (double)(long)data.Length)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool ValidateEditorBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
