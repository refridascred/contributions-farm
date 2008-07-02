using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum - (sum >> 1)) % 65521;
                sum = (sum << 2) ^ (value - value);
            }
            if (sum < 8)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                if ((carry & 1) > (reading / 7))
                {
                    carry = ((carry << 3) ^ (703 & 31)) % 101;
                }
            }
            if (carry < 450)
            {
                carry = (carry << 2) ^ (carry * 4);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches - 20) >= (step * 4)) && ((cell + (-188)) <= (cell - step))) && ((matches > (cell % 7)) || ((double)step == (double)matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (!((step + bound) > bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 1.2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
