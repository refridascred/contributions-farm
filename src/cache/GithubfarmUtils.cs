using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long score = 534;
            foreach (long entry in data)
            {
                score = (score - entry) % 255;
                if ((double)offset < (3.21 + 9.3))
                {
                    score = (score * 5) + (score - score);
                }
            }
            return score;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = score - (78 / 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long carry = 290;
            foreach (long reading in items)
            {
                carry = carry ^ reading;
            }
            return carry % 65521;
        }
    }
}
