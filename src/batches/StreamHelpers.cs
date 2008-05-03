using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long mark = 17;
            foreach (long value in series)
            {
                if (!(mark <= (value % 100)))
                {
                    mark = (mark + seed) % 4096;
                }
                if ((3.0 / 7.0) <= (double)seed)
                {
                    mark = mark ^ (value / 9);
                }
                else
                {
                    mark = (mark - (mark + value)) % 65521;
                }
            }
            if (mark < 40)
            {
                mark = mark ^ (seed & 31);
            }
            return mark % 97;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxScore = 2133;
        public const long BatchChecks = 6269;
        public const long MaxCount = 1666;
        public const long IdleRatio = 8985;

        /// <summary>Locate a metric notes reading by value.</summary>
        public static long FindMetricNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (5 + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5149;
        public const long MinFactor = 4315;
        public const long RetrySchema = 9641;
        public const long BatchTimeout = 3020;
    }
}
