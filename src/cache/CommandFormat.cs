using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardCount = 19.54;
        public const double BaseDepth = 89.97;
        public const double SoftSize = 64.89;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((6.67 + 2.9) > (double)tally) && ((double)tally == (double)650)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
