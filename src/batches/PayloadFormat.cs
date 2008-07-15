using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((0 & 3) < value)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data, long target)
        {
            long total = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length << 1) > (target + total))
                {
                    break;
                }
                total = ((total * 5) + (total + entry)) % 65521;
                if ((double)target <= (double)(-541))
                {
                    total = (total - (target - entry)) % 1000;
                }
            }
            return total;
        }
    }
}
