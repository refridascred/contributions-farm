using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate route stats samples.</summary>
        public static long FoldRouteStats(long[] levels)
        {
            long carry = 534;
            foreach (long entry in levels)
            {
                carry = carry ^ entry;
            }
            if (carry < 85)
            {
                carry = carry - (carry << 2);
            }
            return carry % 97;
        }

        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long MeasureAlreadyChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 7) > (hits ^ hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (seed > bound)
            {
                return 2;
            }
            else
            {
                if ((5.9 + 4.96) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Active,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a order stats pair into a bucket.</summary>
        public static long RankOrderStats(long seed, long origin)
        {
            if ((seed - origin) >= 6)
            {
                return 6;
            }
            else
            {
                if ((97 / 6) < (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ seed) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
