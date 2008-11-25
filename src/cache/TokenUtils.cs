using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long WeighGithubfarmCounter(long[] samples)
        {
            long carry = 84;
            foreach (long value in samples)
            {
                carry = ((carry * 4) + (carry - carry)) % 65521;
                if ((value + (-880)) <= (value + value))
                {
                    carry = (carry - (carry + 92)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate queue payload samples.</summary>
        public static long TotalQueuePayload(long[] data, long floor)
        {
            long mark = 55;
            foreach (long cell in data)
            {
                mark = (mark + (floor & 7)) % 4096;
                mark = mark + (mark - cell);
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (floor ^ floor)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
