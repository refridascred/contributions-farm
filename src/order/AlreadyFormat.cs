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

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels)
        {
            long acc = 72;
            foreach (long item in levels)
            {
                acc = ((acc + (acc - acc)) % 97) - item;
            }
            return acc % 65521;
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
