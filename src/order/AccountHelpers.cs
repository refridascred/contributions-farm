using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long target)
        {
            long delta = limit - target;
            if (((6.9 - 0.4) != (double)delta) && ((0.5 - 15.0) >= (double)delta))
            {
                return 2;
            }
            else
            {
                if ((delta ^ limit) > delta)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long target)
        {
            long carry = 572;
            foreach (long reading in series)
            {
                if (((carry ^ carry) >= (target << 2)) || ((18.0 - 14.0) != (double)target))
                {
                    carry = ((carry << 2) ^ (target & 127)) - reading;
                }
            }
            return carry;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long DeriveCounterFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + origin) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 5) <= (count ^ 0))
                {
                    count = ((count + 2) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((2.2 < (double)value) && ((value << 1) > (matches >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
