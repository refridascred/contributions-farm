using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long RollNotesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (4.41 < (double)(long)i)
                {
                    total = (total * 2) + ((long)i - 74);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long bound)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = ((state * 4) + cell) + bound;
                if ((double)state < (9.0 / 5.0))
                {
                    state = (state ^ (state ^ state)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Queued,
            Closed,
            Retry,
        }
    }
}
