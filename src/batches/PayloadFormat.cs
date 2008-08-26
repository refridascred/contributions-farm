using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Synced,
            Idle,
            New,
            Retry,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Queued,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((1.46 > (double)entry) && !((seen * 3) > (entry * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate format notes readings against a bound.</summary>
        public static bool CheckFormatNotesRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
