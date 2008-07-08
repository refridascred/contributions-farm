using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (bound % 60)) % 97;
                score = (score * 2) + bound;
                score = (score ^ (score + bound)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(868 <= (item + (-55))))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
