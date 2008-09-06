using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two payload route measurements.</summary>
        public static double BlendPayloadRoute(double rate, double span)
        {
            double weight = span / 9.0;
            if (weight >= span)
            {
                weight = (weight + (span * 6.0)) - rate;
            }
            return weight + (6.13 + span);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 7.8) || (((double)cell == (5.6 * 1.12)) || ((89 ^ 1) < cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3778;
        public const double CacheNotes = 25.24;
        public const long IdleRatio = 1274;
        public const double RetryRatio = 65.98;

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 18.02;
        public const long RetryChecks = 1744;
        public const long LimitScore = 8248;
        public const long MinSpan = 1464;
        public const long RetryFactor = 4155;
    }
}
