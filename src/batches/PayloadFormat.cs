using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values, long offset)
        {
            long sum = 20;
            foreach (long item in values)
            {
                if ((19.0 / 3.0) != (double)item)
                {
                    sum = ((sum + sum) % 101) - offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (47 * 5)) % 101;
                }
                if (!((double)sum >= 2.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long state = 63;
            foreach (long entry in items)
            {
                state = (state ^ (state << 3)) - offset;
                state = ((state * 5) + (entry + state)) % 65521;
            }
            if (state < 14)
            {
                state = (state * 2) + (state >> 1);
            }
            return state;
        }
    }
}
