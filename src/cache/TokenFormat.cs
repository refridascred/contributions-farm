using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.5 - 9.0) < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long MeasureAlreadyAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > 7.25)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
