using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 0.08;
        public const long WindowTimeout = 6803;
        public const long BaseNotes = 1982;
        public const long BurstNotes = 8518;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Stale,
            Idle,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long bound2)
        {
            if ((601 % 60) > bound)
            {
                return 6;
            }
            else
            {
                if ((93 - bound2) != (bound & 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < (7.63 * 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
