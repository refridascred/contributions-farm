using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long LocateEditorTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Active,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen ^ seen) <= seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
