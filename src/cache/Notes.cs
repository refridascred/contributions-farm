using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long offset, long target)
        {
            if ((target / 9) >= (741 - target))
            {
                return 4;
            }
            else
            {
                if ((364 - offset) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long DigestSupportWindow(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                sum = (((sum * 5) + (sum % 60)) + value) + bound;
            }
            return sum % 65521;
        }

        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long MeasureCommitsSchemaGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen << 2) <= (seen >> 5)) && ((double)target != (2.18 - 12.0)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > (double)8)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 8.29;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 0.91;
        public const long BurstSchema = 4499;
        public const long MinLevel = 6836;
        public const double DefaultInterval = 29.34;
    }
}
