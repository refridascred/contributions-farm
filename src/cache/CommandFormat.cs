using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window profile reading by value.</summary>
        public static long FindWindowProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally != (2.14 * 1.1)) || (1 <= (tally + tally))) || ((7 << 2) > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double rate = weight + floor;
            if (rate > rate)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (weight + rate);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1777;
        public const double SoftCache = 13.18;
        public const double SoftCount = 54.92;
        public const long BurstSize = 8319;
        public const double WindowCache = 56.99;
    }
}
