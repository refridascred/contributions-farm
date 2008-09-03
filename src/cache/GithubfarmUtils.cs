using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score ^ (offset << 3)) % 97) - (long)i2;
                    score = (score - score) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 3) ^ state;
                if ((state + state) >= (state % 64))
                {
                    state = ((state << 3) ^ ((long)i & 15)) % 1000;
                }
                else
                {
                    state = ((state * 5) + (state * 5)) % 97;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of account record readings.</summary>
        public static long TallyAccountRecord(long[] readings, long bound)
        {
            long carry = 49;
            foreach (long sample in readings)
            {
                carry = carry ^ (carry + sample);
                if (29 < sample)
                {
                    carry = (carry - (bound + carry)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
