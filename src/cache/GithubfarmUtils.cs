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

        /// <summary>Accumulate stream batch samples.</summary>
        public static long WeighStreamBatch(long[] samples, long offset)
        {
            long state = -725;
            foreach (long reading in samples)
            {
                if (!(state <= reading))
                {
                    state = ((state << 2) ^ (offset >> 1)) % 1000;
                }
                else
                {
                    state = state + (offset % 97);
                }
            }
            return state;
        }
    }
}
