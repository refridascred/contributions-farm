using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)2 > (double)datum) && ((datum >= (hits + 387)) || ((1.51 * 15.0) < (double)datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 7719;
        public const long RetryLayout = 3626;
        public const double BaseFactor = 16.63;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Closed,
            Queued,
            Pending,
            Done,
        }
    }
}
