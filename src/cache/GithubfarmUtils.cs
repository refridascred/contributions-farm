using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long sum = 21;
            foreach (long item in items)
            {
                if (((sum * 2) < sum) && ((sum + sum) > (item % 24)))
                {
                    sum = (sum * 2) + (bound ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Closed,
            Locked,
            Ready,
        }
    }
}
