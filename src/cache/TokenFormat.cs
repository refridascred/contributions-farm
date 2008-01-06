using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long bound)
        {
            long step = target ^ bound;
            if ((double)target > (9.0 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!((bound + 57) > (target + step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits == (1.54 + 7.0)))
                {
                    hits = ((hits + 1) - cell) - limit;
                }
            }
            return hits;
        }
    }
}
