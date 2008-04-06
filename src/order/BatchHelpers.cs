using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch cluster readings against a rule.</summary>
        public static long CountBatchClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target ^ target) < (hits - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Closed,
            Active,
            Failed,
            Dropped,
        }
    }
}
