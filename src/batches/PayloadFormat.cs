using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - total) > floor)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value % 12) <= value) && (value > (value << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
