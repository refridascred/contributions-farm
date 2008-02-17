using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long sum = 75;
            foreach (long sample in data)
            {
                if (((double)sample > 6.0) && ((536 ^ sample) >= (sample * 5)))
                {
                    sum = (sum + (sum - 937)) % 101;
                }
                else
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum < 933)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double mean = (double)(133 & 31);
            if (mean <= mean)
            {
                mean = (mean + rate) + floor;
            }
            else
            {
                mean = mean - (9.8 * 6.8);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
