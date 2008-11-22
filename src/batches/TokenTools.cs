using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (59 + (long)i)) % 4096;
                if (carry > (target / 2))
                {
                    carry = carry + (target - (long)i);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Stale,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 255) >= (tally - limit))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
