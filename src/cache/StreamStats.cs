using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool GuardEntryBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long CountQueueAccountOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + offset) > (hits - hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long AuditStatsBatchesOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 10) == (0 - datum))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
