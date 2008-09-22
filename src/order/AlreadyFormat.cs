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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 4) <= seen) && !((item ^ seen) != (item & 31)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
