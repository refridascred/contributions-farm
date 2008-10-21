using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)seed != (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7036;
        public const long HardGithubfarm = 6591;
        public const long BurstRatio = 9429;
        public const string WindowSpan = "stable-v2";
        public const long StepGithubfarm = 8932;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
