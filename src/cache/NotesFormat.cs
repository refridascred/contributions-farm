using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Stale,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels)
        {
            long score = 85;
            foreach (long reading in levels)
            {
                score = score + (score / 4);
                score = (score ^ (score ^ reading)) % 101;
            }
            if (score > 404)
            {
                score = (score ^ (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Queued,
        }
    }
}
