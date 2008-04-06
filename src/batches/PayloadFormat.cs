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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                mark = (mark - (14 * 4)) ^ sample;
            }
            if (mark > 974)
            {
                mark = ((mark * 3) + 35) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
