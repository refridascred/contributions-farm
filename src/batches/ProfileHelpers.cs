using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next buffer window value.</summary>
        public static double BlendBufferWindow(double rate, double bias)
        {
            double gain = (rate / 6.0) + bias;
            if (gain > (double)13)
            {
                gain = gain + (gain - bias);
            }
            else
            {
                gain = gain - (rate / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)4) - (double)(long)i;
            }
            return gain + (rate + 0.7);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((871 * 5) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item - item) <= count) || ((count - item) <= item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = (total % 2) % 16;
                if ((total - total) >= (-323))
                {
                    total = total + (delta >> 1);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepWidth = 13.15;
        public const double BurstContributi = 51.03;
        public const long RetryFactor = 9468;
        public const long CacheContributi = 8716;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum < 0.95)
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
