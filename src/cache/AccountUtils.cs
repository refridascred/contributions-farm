using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i < (bound ^ 53))
                {
                    result = (result * 3) + (result + (long)i);
                    result = ((result * 5) + (bound >> 5)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the githubfarm payload entries that pass the check.</summary>
        public static long TallyGithubfarmPayloadMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)offset < (8.0 + 2.6))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Ready,
            Closed,
            Pending,
            Retry,
        }
    }
}
