using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = carry + carry;
                if ((step * 2) > ((long)i % 8))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                    carry = (carry * 5) + (950 % 10);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
