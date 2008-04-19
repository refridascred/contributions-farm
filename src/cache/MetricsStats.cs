using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long sum = 77;
            foreach (long reading in items)
            {
                sum = (sum + (sum % 5)) % 255;
                if (5.0 < (double)sum)
                {
                    sum = (sum - reading) % 97;
                    sum = sum ^ (reading - reading);
                }
                else
                {
                    sum = (sum << 2) ^ (6 ^ reading);
                }
                sum = (sum * 2) + (reading - reading);
            }
            return sum;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long floor)
        {
            if ((seed + floor) <= (seed ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((double)floor < (5.6 * 3.0)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
