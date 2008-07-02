using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes session value from a seed.</summary>
        public static long RollNotesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (621 - carry)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + (carry >> 5)) + (long)i2;
                }
                carry = carry ^ seed;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Failed,
            New,
            Pending,
            Dropped,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long bound)
        {
            long next = limit + bound;
            if ((bound ^ limit) <= 213)
            {
                return 8;
            }
            else
            {
                if ((14.0 / 6.0) == (double)next)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if ((carry & 15) > (item & 7))
                {
                    carry = ((carry * 5) + (carry + 9)) % 1000;
                }
            }
            return carry;
        }
    }
}
