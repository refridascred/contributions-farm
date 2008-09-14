using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 613;
        public const long LimitCount = 5542;
        public const long CacheTools = 6678;

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
