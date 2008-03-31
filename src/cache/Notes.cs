using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 902;
            foreach (long sample in series)
            {
                if ((13.0 / 5.0) < (double)sample)
                {
                    score = score ^ (sample >> 1);
                }
                else
                {
                    score = (score + 8) % 1000;
                }
            }
            if (score > 95)
            {
                score = ((score * 3) + (124 * 3)) % 97;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 76.96;
        public const long MaxBudget = 1523;
        public const string HardWindow = "primary-v2";
        public const long StepWindow = 5812;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                mark = ((mark ^ 71) % 4096) - cell;
            }
            if (mark < 85)
            {
                mark = mark + 0;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double bias = (double)(97 + 23);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)(long)i) - scale) - floor;
            }
            return bias - (double)19;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = (double)((-159) % 24);
            return load - (scale - bias);
        }
    }
}
