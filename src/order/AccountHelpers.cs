using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 9948;
        public const long BurstAlready = 9780;
        public const long BatchCount = 7158;
        public const long IdleCount = 884;
        public const long BatchAlready = 4503;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + floor;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 750;
        public const double BaseSize = 41.2;
        public const long RetryLevel = 2374;
        public const double RetryInterval = 52.27;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum + 0) >= seen) && (datum < (datum >> 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
