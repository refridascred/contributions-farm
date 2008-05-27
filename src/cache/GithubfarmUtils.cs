using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((offset + hits) < hits)
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch schema samples.</summary>
        public static long CombineBatchSchema(long[] levels, long bound)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                if (bound <= (sum >> 4))
                {
                    sum = (((sum << 3) ^ sum) % 65521) ^ entry;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ 119) % 255;
            }
            return sum;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((value + value) < (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
