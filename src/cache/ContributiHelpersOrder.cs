using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Locked,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples)
        {
            long total = -169;
            foreach (long item in samples)
            {
                if ((item + item) > total)
                {
                    total = (total << 3) ^ 85;
                }
            }
            return total;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            New,
            Paused,
            Done,
        }
    }
}
