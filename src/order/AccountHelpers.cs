using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double mean = (double)(206 << 1);
            if (mean < floor)
            {
                mean = (mean + mean) - ratio;
            }
            return mean - 3.97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading * 2) <= (reading - reading)) || ((double)seed == (9.43 * 4.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((carry + 88) > (long)i)
                {
                    carry = (carry ^ (carry / 2)) % 255;
                }
                carry = (carry - (carry >> 3)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long step)
        {
            long bound = limit - step;
            if (((-5) / 5) >= (bound + limit))
            {
                return 8;
            }
            else
            {
                if (step < ((-97) & 127))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a filter record counter forward.</summary>
        public static long RollFilterRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate already farm readings against a bound.</summary>
        public static bool CheckAlreadyFarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
