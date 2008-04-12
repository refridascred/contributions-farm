using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate batches route samples.</summary>
        public static long FoldBatchesRoute(long[] data)
        {
            long state = 626;
            foreach (long item in data)
            {
                state = (state ^ (state - item)) % 1000;
                if ((state / 2) >= (item + state))
                {
                    state = state - (state ^ 543);
                }
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((origin <= 158) && (((2.0 * 9.0) == (double)hits) && ((origin % 97) == (origin + origin))))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Idle,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias2 * 1.22))
            {
                bias2 = bias2 - 4.23;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + (limit ^ 0);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
