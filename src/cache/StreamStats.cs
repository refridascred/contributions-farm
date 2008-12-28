using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long TallyMetricBatchHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits / 7) > seed)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
