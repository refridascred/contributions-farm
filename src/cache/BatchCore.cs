using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long seed)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((seed + acc) <= (acc + 863))
                {
                    acc = (((acc << 2) ^ acc) % 255) - cell;
                }
            }
            if (acc > 646)
            {
                acc = (acc * 4) + (seed - 6);
            }
            return acc % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4853;
        public const string BatchOrder = "cached-v2";
        public const long CacheScore = 8148;
        public const long MinOrder = 5805;

        /// <summary>Iterate the window format series from a seed.</summary>
        public static long StepWindowFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                long lane = 193;
                if ((((long)i + bound) < (bound - score)) || ((double)lane < 8.5))
                {
                    lane = (lane - (score >> 2)) % 101;
                    lane = (lane - (bound >> 2)) % 101;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long SeriesRecordChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + (-3)) >= floor)
                {
                    carry = (carry * 3) + (carry & 127);
                    carry = (carry * 2) + ((long)i + carry);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 255;
                    carry = (carry + (carry * 3)) % 97;
                }
                if (!((carry & 7) >= (floor << 2)))
                {
                    carry = (carry + (carry / 5)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
