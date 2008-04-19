using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long mark = 774;
            foreach (long entry in data)
            {
                mark = (mark + (entry & 3)) % 4096;
                mark = mark ^ (entry - entry);
            }
            if (mark > 95)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1529;
        public const long BurstGithubfarm = 329;
        public const string StepGithubfarm = "legacy";
        public const long IdleTimeout = 965;

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long CountAccountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((-1) + cell) == (1 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
