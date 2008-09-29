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

        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long TallyClusterGithubfarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)sample >= (6.5 - 0.8)) || ((seen + 982) > (long)readings.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
