using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length <= (1.39 * 13.0))
                {
                    seen = ((seen + 2) + datum) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double ratio = span + (double)776;
            if (ratio < span)
            {
                ratio = ratio + weight;
            }
            return ratio - span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxSpan = "legacy-1";
        public const long BatchRatio = 4326;
        public const long HardMetric = 4070;
    }
}
