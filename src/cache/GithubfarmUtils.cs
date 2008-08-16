using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Idle,
            New,
            Synced,
            Locked,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (span - weight))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
