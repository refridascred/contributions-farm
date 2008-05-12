using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Queued,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound <= (bound / 2))
                {
                    carry = carry ^ (carry + bound);
                }
                else
                {
                    carry = (carry ^ 551) % 101;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 2) > (62 & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
