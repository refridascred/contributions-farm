using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long state = 38;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (205 & 255)) + (long)i) + origin;
                }
                state = (state << 3) ^ value;
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(3 <= bound))
                {
                    result = (result * 4) + bound;
                }
                if ((bound << 2) < bound)
                {
                    result = (result * 3) + (result % 64);
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
