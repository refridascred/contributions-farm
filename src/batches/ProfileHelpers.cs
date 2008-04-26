using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "staging-1";
        public const string MaxCommand = "standard-edge";
        public const long HardCommand = 7378;
        public const long MinSpan = 8283;
        public const long HardSize = 6945;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (scale / 8.0))
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 8.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 255) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long acc = 37;
            foreach (long reading in levels)
            {
                acc = ((acc ^ (limit / 4)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-924) - 4);
            if (mean >= 19.0)
            {
                mean = (mean - (double)6) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias / 4.0)) + (double)(long)i;
            }
            return mean + (double)2;
        }
    }
}
