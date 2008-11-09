using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry > (count & 7)) || ((target ^ count) != (target + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const string BaseBudget = "local-1";
        public const long MaxSupport = 3506;
        public const long DefaultSupport = 223;
        public const long LimitSupport = 8825;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long floor)
        {
            if (((87 >> 3) <= floor) && ((bound - 879) <= (floor >> 5)))
            {
                return 6;
            }
            else
            {
                if ((floor - bound) >= (floor + bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
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
