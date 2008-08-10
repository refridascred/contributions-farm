using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel tools entry stays within the limit.</summary>
        public static bool CheckChannelToolsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long TallyAlreadyCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (6 + item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 4) + carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
