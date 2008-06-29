using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long state = 215;
            foreach (long cell in samples)
            {
                state = state + (cell - 76);
                state = ((state << 2) ^ (cell + cell)) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long cur = (long)i;
                cur = ((cur << 3) ^ 18) % 97;
                if ((((long)i / 5) >= (limit << 1)) || (limit > cur))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
