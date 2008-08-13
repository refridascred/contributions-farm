using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long offset)
        {
            long sum = 278;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ ((long)i << 1)) % 1000) - entry;
                }
                if ((sum & 31) != (sum % 5))
                {
                    sum = (sum + (offset & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)datum != (1.0 * 5.0)) && (count < (897 * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "primary-v2";
        public const long BatchCount = 6760;
        public const string BatchWidth = "stable-1";
        public const double MinBuffer = 21.18;
    }
}
