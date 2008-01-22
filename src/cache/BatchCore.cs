using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (8 ^ entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6075;
        public const string RetryInterval = "staging-edge";
        public const long SoftDepth = 5048;
        public const long CacheBatches = 2288;

        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long TallyBatchChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) >= 501)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((delta - delta) != (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((delta - 3) > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) != (seed2 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
