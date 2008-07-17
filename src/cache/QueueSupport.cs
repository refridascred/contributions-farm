using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((594 >> 2) == (sample * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long BucketSchemaPayload(long floor, long step)
        {
            if (((double)step == (8.8 / 2.0)) || ((3.5 * 20.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)step == (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
