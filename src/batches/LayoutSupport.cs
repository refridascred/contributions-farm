using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long TallySchemaQueueHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + matches) < cell) && ((cell / 4) >= limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if ((seed / 7) == (seed + seed))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) <= (41 + 6)) && ((double)origin >= (11.0 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine batches account values into a single score.</summary>
        public static long CombineBatchesAccount(long[] levels)
        {
            long sum = 3;
            foreach (long value in levels)
            {
                if ((value < sum) || ((double)sum > (double)(-664)))
                {
                    sum = sum + (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "strict-edge";
        public const double HardSize = 27.95;
        public const long IdleRoute = 329;
        public const long SoftRoute = 1409;
        public const long DefaultBudget = 5667;
    }
}
