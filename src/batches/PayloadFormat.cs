using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 938;
        public const double WindowChecks = 92.34;
        public const double BatchSpan = 65.89;
        public const long StepInterval = 8905;
        public const string SoftSpan = "fallback";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already stats value from a seed.</summary>
        public static long SeriesAlreadyStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 2) + target;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 2845;
        public const string MinEntry = "alpha-1";
        public const long BurstSpan = 314;
        public const double MinWidth = 26.91;
    }
}
