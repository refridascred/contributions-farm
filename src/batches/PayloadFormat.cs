using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count == (double)(-911))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools stream samples.</summary>
        public static long WeighToolsStream(long[] samples, long origin)
        {
            long carry = 43;
            foreach (long sample in samples)
            {
                if ((double)carry <= 11.0)
                {
                    carry = ((carry + sample) % 97) - origin;
                }
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items, long offset)
        {
            long anchor = 285;
            foreach (long entry in items)
            {
                if ((5.6 / 6.0) > (double)entry)
                {
                    anchor = ((anchor - (entry * 4)) % 255) - offset;
                }
                if ((4.8 - 12.0) == (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 929)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long floor)
        {
            long sum = 446;
            foreach (long item in values)
            {
                if ((double)item <= (double)sum)
                {
                    sum = sum ^ (item + sum);
                }
                if ((floor & 3) >= (sum ^ sum))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (277 + item);
                }
            }
            return sum;
        }
    }
}
