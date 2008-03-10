using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
