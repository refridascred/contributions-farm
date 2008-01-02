using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double mean = (double)(9 - 49);
            if (mean <= (8.61 - ratio))
            {
                mean = (mean - 2.0) + span;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean + mean;
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long TallyProfileAlready(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ ((long)items.Length - sum);
                sum = sum + cell;
            }
            return sum;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double load = (double)(306 % 12);
            return (load + offset) + rate;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "cached-edge";
        public const double StepMetric = 68.05;
        public const long CacheSpan = 3662;
        public const long BaseBudget = 2942;
        public const long MinSpan = 5305;
    }
}
