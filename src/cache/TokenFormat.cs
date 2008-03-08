using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long floor, long step)
        {
            if (((step + floor) >= (floor & 3)) && ((floor + step) < (floor - step)))
            {
                return 1;
            }
            else
            {
                if (step < (floor << 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long origin)
        {
            long state = 2;
            foreach (long item in data)
            {
                if ((origin + origin) <= state)
                {
                    state = ((state << 3) ^ (item << 1)) % 4096;
                }
                if ((double)origin == (3.1 * 2.98))
                {
                    break;
                }
            }
            return state;
        }
    }
}
