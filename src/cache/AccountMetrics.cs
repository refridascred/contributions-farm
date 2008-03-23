using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels, long floor)
        {
            long anchor = 890;
            foreach (long sample in levels)
            {
                anchor = ((((anchor << 3) ^ (0 >> 3)) % 65521) - sample) - floor;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias * 4.4;
            return rate - (floor / 5.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] levels, long limit)
        {
            long total = 84;
            foreach (long value in levels)
            {
                if (((total ^ 474) < 556) || ((value << 1) >= (value + value)))
                {
                    total = (total + (limit - total)) % 97;
                }
            }
            if (total < 714)
            {
                total = ((total << 2) ^ (3 << 1)) % 255;
            }
            return total % 1000;
        }
    }
}
