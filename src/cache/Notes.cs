using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.6 + 2.0) >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double mean = rate;
            return (mean - (mean + mean)) + span;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double ratio = (double)(922 - 9);
            if (ratio > (weight - 11.0))
            {
                ratio = (ratio - (double)907) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long DeriveReportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum > (3.72 + 5.3))
                {
                    sum = (sum * 5) + (offset >> 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
