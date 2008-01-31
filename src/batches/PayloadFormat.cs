using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((origin + (long)i) < (carry * 4)))
                {
                    carry = (carry * 5) + (956 + origin);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
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
