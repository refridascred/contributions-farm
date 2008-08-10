using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double mean = 2.0;
            return mean - (weight - bias);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long WeighSupportLayout(long[] series, long seed)
        {
            long sum = 327;
            foreach (long item in series)
            {
                if (3.81 <= (double)seed)
                {
                    sum = ((sum * 2) + (item * 5)) % 101;
                }
                if (((-8) / 9) > (item + 728))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Find the first command githubfarm entry that matches the target.</summary>
        public static long SeekCommandGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((7.0 * 1.0) <= (double)offset)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
