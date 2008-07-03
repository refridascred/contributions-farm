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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long bound)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = (mix ^ (bound + bound)) % 65521;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 5) + (bound - cell)) + (long)i;
                }
                mix = mix + (cell % 2);
            }
            return mix;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long WeighRecordLayout(long[] items)
        {
            long mark = 541;
            foreach (long item in items)
            {
                mark = (mark ^ (mark + (-68))) % 101;
                if (16.0 <= (double)mark)
                {
                    mark = mark ^ (item >> 4);
                }
            }
            return mark;
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
