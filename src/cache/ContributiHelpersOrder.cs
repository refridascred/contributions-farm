using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Check that every schema support entry stays within the limit.</summary>
        public static bool VerifySchemaSupportBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
