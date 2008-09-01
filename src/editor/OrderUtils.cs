using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Count the booking entries that pass the check.</summary>
        public static long CountBookingMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= count)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (34 <= count)
                {
                    count = ((count + 3) + cell) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long ClassifyWindowCommits(long floor, long offset)
        {
            long next = floor + offset;
            if (!((offset ^ next) != (next * 3)))
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) != ((-119) % 100))
                {
                    return 3;
                }
                else
                {
                    if ((7.0 - 8.0) == (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
