using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
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
