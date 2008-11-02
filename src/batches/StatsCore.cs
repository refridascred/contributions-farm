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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long acc = 38;
            foreach (long item in items)
            {
                if ((long)items.Length == (acc + acc))
                {
                    acc = (acc << 3) ^ (acc & 7);
                }
                else
                {
                    acc = acc + item;
                }
            }
            if (acc > 13)
            {
                acc = acc ^ 320;
            }
            return acc;
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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Paused,
            Retry,
            Locked,
            Draft,
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
