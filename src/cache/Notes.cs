using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of stats contributi readings.</summary>
        public static long PairStatsContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstScore = "local-edge";
        public const long SoftCluster = 4789;
        public const double SoftTimeout = 61.13;

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
