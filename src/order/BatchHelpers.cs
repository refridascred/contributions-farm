using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count > (8.6 * 2.51)) && (entry > (entry >> 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum >= (5.8 / 7.0)) || ((datum << 3) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (step / 5))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
