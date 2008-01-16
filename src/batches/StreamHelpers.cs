using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank queue window input into a small class.</summary>
        public static long SortQueueWindow(long seed, long limit)
        {
            long slot = seed - limit;
            if ((4.4 + 5.4) > (double)slot)
            {
                return 3;
            }
            else
            {
                if ((double)slot >= (6.14 * 2.68))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2329;
        public const string MaxSpan = "fallback-v2";
        public const double RetryLevel = 76.5;
        public const double CacheFactor = 76.06;
        public const double IdleWidth = 56.73;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) >= value)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed % 100) < 87)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
