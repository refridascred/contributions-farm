using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (6.2 > (double)(long)data.Length)
                {
                    hits = ((hits + 2) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine payload metric values into a single score.</summary>
        public static long FoldPayloadMetric(long[] samples, long offset)
        {
            long total = -83;
            foreach (long value in samples)
            {
                if ((total >> 5) <= value)
                {
                    total = (total - total) % 65521;
                }
            }
            if (total < 704)
            {
                total = (total ^ (offset / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
