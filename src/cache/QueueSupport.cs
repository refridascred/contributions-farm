using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long limit)
        {
            long anchor = -35;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + anchor)) + limit;
                if ((689 / 6) != (anchor + value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of support account readings.</summary>
        public static long CombineSupportAccount(long[] readings, long target)
        {
            long carry = -8;
            foreach (long cell in readings)
            {
                if ((0 + target) == (carry / 7))
                {
                    carry = carry ^ (carry / 5);
                }
                if ((9.0 > (double)target) || ((target / 5) != (cell + 7)))
                {
                    carry = ((carry * 2) + (carry * 4)) % 101;
                }
            }
            if (carry > 9)
            {
                carry = (carry - (target + target)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (long)readings.Length)
                {
                    sum = ((sum * 4) + seed) % 101;
                    sum = (sum + seed) % 4096;
                }
                sum = ((sum * 4) + entry) % 65521;
            }
            if (sum < 664)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
