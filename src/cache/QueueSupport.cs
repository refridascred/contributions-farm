using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue farm readings.</summary>
        public static long DigestQueueFarm(long[] levels)
        {
            long total = -39;
            foreach (long item in levels)
            {
                if ((total <= (total % 16)) && ((8.8 / 2.0) > (double)total))
                {
                    total = ((total * 4) + (item + item)) % 101;
                }
                if ((item - total) < (item + item))
                {
                    total = (total - total) % 65521;
                }
                if ((total % 7) > (total >> 3))
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            if (total < (-7))
            {
                total = ((total * 5) + (5 % 64)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long CountRouteGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches >= (matches ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
