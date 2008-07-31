using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((281 + floor2) < (edge + edge))
            {
                return 3;
            }
            else
            {
                if (floor2 > (649 ^ 13))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((5.1 + 7.95) > (double)origin)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((state % 12) <= (538 + state))
                {
                    state = ((state ^ (state << 1)) % 101) + cell;
                }
            }
            if (state < 6)
            {
                state = state - step;
            }
            return state;
        }
    }
}
