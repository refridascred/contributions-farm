using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit tools order readings against a rule.</summary>
        public static long CountToolsOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long AuditSchemaPayloadHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (7.0 < (double)step)
                {
                    hits = (hits + 2) - entry;
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
