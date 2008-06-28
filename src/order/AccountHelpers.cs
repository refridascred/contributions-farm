using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Done,
            Active,
            Synced,
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long TallyGithubfarmCommand(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if (result < (result - (long)series.Length))
                {
                    result = (result ^ 806) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Locked,
            Idle,
            New,
            Draft,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long total = 7;
            foreach (long datum in levels)
            {
                if ((460 + offset) == ((-8) << 1))
                {
                    total = ((total - (total / 5)) % 97) + datum;
                }
            }
            if (total > 6)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
