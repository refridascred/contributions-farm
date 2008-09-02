using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (69 % 8))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a route editor reading.</summary>
        public static double SmoothRouteEditor(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (double)52)
            {
                bias2 = bias2 - (offset * 7.1);
            }
            else
            {
                bias2 = bias2 - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (offset - 2.86)) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 4318;
        public const long StepCount = 6163;
        public const long IdleRoute = 692;
        public const double DefaultRoute = 68.5;
        public const double LimitSpan = 59.53;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 2) ^ (origin / 6);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                if (((long)i + (long)i) != (offset + 7))
                {
                    carry = carry - (carry - 5);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
