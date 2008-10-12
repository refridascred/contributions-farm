using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 3) ^ (target - anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm entry readings against a bound.</summary>
        public static bool CheckGithubfarmEntryBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = state + offset;
                if (((long)i & 15) <= (long)i)
                {
                    state = (state + ((long)i - offset)) % 1000;
                    state = (state - ((long)i ^ offset)) % 255;
                }
                else
                {
                    state = state ^ (offset & 127);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - (offset + state)) % 97) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
