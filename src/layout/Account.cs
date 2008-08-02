using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long TallyGraphQueue(long[] levels)
        {
            long state = 617;
            foreach (long datum in levels)
            {
                if (8.1 < (double)state)
                {
                    state = (state - (2 / 4)) - datum;
                }
            }
            if (state < 0)
            {
                state = ((state << 2) ^ (state / 4)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(long)i <= 6.43)
                {
                    carry = carry + (carry / 2);
                    continue;
                }
                if (!(((long)i % 2) <= (carry << 2)))
                {
                    carry = carry ^ ((long)i + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
