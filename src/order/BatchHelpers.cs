using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit report cache readings against a rule.</summary>
        public static long MeasureReportCacheOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= (entry * 3))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long AuditStreamTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (count + count))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ ((long)i2 - offset)) % 97;
                    result = result + offset;
                }
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
