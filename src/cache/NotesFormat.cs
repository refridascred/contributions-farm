using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first counter report entry that matches the target.</summary>
        public static long FindCounterReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
