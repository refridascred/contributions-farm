using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of profile tools entries.</summary>
        public static long ScoreProfileTools(long[] samples, long seed)
        {
            long mix = 37;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (seed * 5)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "staging-v2";
        public const double SoftFactor = 78.48;
        public const long MinCommits = 1851;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
