using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long seed)
        {
            long carry = 319;
            foreach (long item in data)
            {
                carry = (((carry << 3) ^ seed) % 4096) - item;
            }
            return carry % 1000;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + 6) % 255;
                if ((seed - sum) >= (62 % 64))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = (sum ^ 752) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)origin == (3.0 / 5.0))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
