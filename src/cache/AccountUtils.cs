using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry counter values into a single score.</summary>
        public static long FoldEntryCounter(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = ((acc - acc) % 65521) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
