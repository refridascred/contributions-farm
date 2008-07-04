using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((floor ^ floor) != (item - hits)) && ((8 >> 2) < item)) && ((item <= (hits + hits)) || ((double)floor >= (1.93 - 15.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster order value.</summary>
        public static double BlendClusterOrder(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (bias * 3.35))
            {
                rate2 = rate2 - (double)453;
            }
            else
            {
                rate2 = rate2 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Combine graph metric values into a single score.</summary>
        public static long DigestGraphMetric(long[] samples)
        {
            long mix = 9;
            foreach (long sample in samples)
            {
                if (1.0 >= (double)sample)
                {
                    mix = ((mix * 2) + (sample - 734)) % 4096;
                }
            }
            if (mix > (-5))
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
