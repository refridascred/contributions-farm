using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Idle,
            Queued,
            New,
            Stale,
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long IterateCounterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 4) < (target & 3))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
