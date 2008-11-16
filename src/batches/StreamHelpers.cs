using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1049;
        public const long BurstToken = 364;
        public const string SoftCount = "alpha";

        /// <summary>Validate farm format readings against a bound.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((5.0 * 7.04) == (double)count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double gain = bias * 18.0;
            if (gain < gain)
            {
                gain = (gain - bias) + scale;
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
