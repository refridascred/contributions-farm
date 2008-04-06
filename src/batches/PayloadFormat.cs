using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit batches schema readings against a rule.</summary>
        public static long CountBatchesSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (8.46 / 6.0))
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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long target)
        {
            long diff = offset + target;
            if ((1.72 + 16.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((diff & 127) == (offset + offset)) && ((74 / 2) > (offset % 2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (0.19 - 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Locked,
            Synced,
        }
    }
}
