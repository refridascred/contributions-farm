using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches token readings against a rule.</summary>
        public static long TallyBatchesTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen == (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long AuditBatchesChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry ^ hits) < (hits % 60))
                {
                    hits = hits + 1;
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
