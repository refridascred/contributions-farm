using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session batches values into a single score.</summary>
        public static long FoldSessionBatches(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long datum in readings)
            {
                anchor = (anchor + (384 + datum)) % 101;
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor << 2) ^ step) % 4096) ^ (long)i;
                }
                if ((step * 4) < anchor)
                {
                    anchor = (anchor * 5) + (step << 2);
                }
                else
                {
                    anchor = (anchor - (step >> 1)) % 101;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor * 4) + (step * 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long DigestCommitsContext(long[] values, long offset)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if (offset < result)
                {
                    result = (((result << 3) ^ (offset << 2)) % 1000) - reading;
                }
            }
            if (result < 3)
            {
                result = result + (result * 2);
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((20.0 - 5.46) < (double)target) && ((target + seen) < (42 - seen))) && ((target <= (seen - seen)) && ((double)seen != (double)9)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
