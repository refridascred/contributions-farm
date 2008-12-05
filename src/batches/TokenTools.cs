using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 3) ^ (6 + state)) % 97;
                if ((state + 639) > (long)i)
                {
                    state = (state * 3) + (long)i;
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings, long limit)
        {
            long total = 37;
            foreach (long sample in readings)
            {
                if ((2 - sample) < (limit >> 5))
                {
                    total = (total + (sample % 24)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
