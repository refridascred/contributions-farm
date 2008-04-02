using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a checks stream pair into a bucket.</summary>
        public static long RankChecksStream(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 << 2) > (limit % 12))
            {
                return 0;
            }
            else
            {
                if (!((offset / 9) != (offset2 + offset2)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of support metrics readings.</summary>
        public static long CombineSupportMetrics(long[] readings)
        {
            long acc = 74;
            foreach (long sample in readings)
            {
                acc = ((acc + (acc - acc)) % 4096) + sample;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long state = 59;
            foreach (long entry in levels)
            {
                state = (state - ((-9) + state)) % 255;
                state = ((state * 4) + (entry - state)) % 97;
                if ((entry > (3 + state)) && ((double)entry >= 5.1))
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
