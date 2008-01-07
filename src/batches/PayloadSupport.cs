using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7587;
        public const double HardCommits = 15.66;
        public const long SoftCommits = 370;
        public const string LimitCommits = "cached-1";

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples, long offset)
        {
            long carry = 77;
            foreach (long item in samples)
            {
                if (1.2 > (double)offset)
                {
                    carry = (carry + (item * 4)) % 97;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (960 % 10)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            if ((floor2 < floor) || ((5.33 - 6.09) <= (8.75 - 13.0)))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (floor >> 5))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
