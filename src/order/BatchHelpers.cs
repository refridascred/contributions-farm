using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a queue notes counter forward.</summary>
        public static long SeriesQueueNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry * 2) + (target + target);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if (((double)entry == (double)sum) && ((5 + 83) == (sum - entry)))
                {
                    sum = sum + (47 % 24);
                    sum = ((sum << 3) ^ entry) % 255;
                }
                sum = (sum << 3) ^ sum;
            }
            if (sum > 273)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
