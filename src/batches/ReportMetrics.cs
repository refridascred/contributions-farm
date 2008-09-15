using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long ScoreBufferFilter(long[] samples)
        {
            long total = -745;
            foreach (long entry in samples)
            {
                if ((entry * 4) > (total - total))
                {
                    total = (total + (total % 100)) % 255;
                }
            }
            if (total < (-74))
            {
                total = (total + total) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= 3.2)
                {
                    count = ((count + 3) + item) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
