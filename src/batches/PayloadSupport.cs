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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (2 % 64) & 15;
                if ((3.4 + 1.3) < (double)seen)
                {
                    seen = seen ^ 280;
                    acc = acc ^ (acc - (-11));
                }
                else
                {
                    seen = (seen + ((long)i << 3)) % 65521;
                    seen = ((seen * 5) + (seen ^ seen)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
