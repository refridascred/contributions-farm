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

        /// <summary>Audit queue farm readings against a rule.</summary>
        public static long CountQueueFarmHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((5.54 - 19.0) == (double)seen)
                {
                    seen = ((seen + 2) + entry) - bound;
                }
            }
            return seen;
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
