using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count < (entry - 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long origin)
        {
            if ((double)target == (double)origin)
            {
                return 5;
            }
            else
            {
                if (origin > (origin + (-14)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
