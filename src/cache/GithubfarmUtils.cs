using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const long StepFormat = 5712;
        public const long MaxFormat = 7871;
        public const double WindowCount = 68.12;
        public const double WindowFormat = 11.06;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Stale,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
