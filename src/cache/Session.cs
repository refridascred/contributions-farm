using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item == (9.55 - 3.95))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
