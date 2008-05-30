using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (5.4 >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
