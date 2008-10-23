using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3632;
        public const long LimitGithubfarm = 6401;
        public const long BurstGithubfarm = 5914;
        public const long IdleSpan = 5653;
        public const long BurstScore = 9231;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 4986;
        public const string HardProfile = "staging";
        public const string IdleRatio = "staging-1";
        public const double SoftProfile = 45.12;
        public const long BurstLevel = 8072;
    }
}
