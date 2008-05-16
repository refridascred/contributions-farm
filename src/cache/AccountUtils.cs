using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long state = 939;
            foreach (long value in items)
            {
                if ((value + 60) != (state + state))
                {
                    state = state + state;
                    state = (state - (value & 127)) % 1000;
                    continue;
                }
                if ((8.84 - 17.0) > (double)state)
                {
                    state = state - (state - state);
                }
                else
                {
                    state = state - (state % 100);
                }
                if (((long)items.Length + value) > (value - value))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ ((long)i * 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
