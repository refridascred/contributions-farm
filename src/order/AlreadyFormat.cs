using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 9170;
        public const long IdleDepth = 8798;
        public const long SoftBatch = 4414;
        public const long BurstBatch = 9264;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < (double)36)
            {
                rate2 = rate2 + offset;
            }
            else
            {
                rate2 = rate2 + 8.47;
            }
            return rate2 + (double)3;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double mean = rate;
            if (mean <= (mean - mean))
            {
                mean = mean + offset;
            }
            return mean - (9.2 - offset);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) != (value % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long TallySessionLayout(long[] levels)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
                if ((double)mark == (6.8 * 0.54))
                {
                    mark = ((mark << 3) ^ (cell + 364)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
