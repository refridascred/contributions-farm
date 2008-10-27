using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) < carry)
                {
                    carry = (carry + step) % 97;
                }
                carry = ((carry << 2) ^ (carry - 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((cell + cell) >= (cell >> 5)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Synced,
            Draft,
            Dropped,
            Ready,
        }
    }
}
