using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long limit)
        {
            long result = 404;
            foreach (long datum in series)
            {
                if ((limit + result) <= result)
                {
                    result = ((result << 2) ^ (datum + limit)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double bias = scale;
            if (bias >= (scale / 9.0))
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (2.4 - bias);
        }

        /// <summary>Roll a context metric counter forward.</summary>
        public static long DeriveContextMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ bound) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix * 3) + (bound ^ bound)) + (long)i2;
                    mix = mix - (mix - bound);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2218;
        public const long HardWidth = 2216;
        public const long RetryRecord = 1633;
        public const double CacheBudget = 89.91;
    }
}
