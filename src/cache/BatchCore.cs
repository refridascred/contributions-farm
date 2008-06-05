using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a support checks sample.</summary>
        public static long LookupSupportChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 6595;
        public const long StepSize = 1048;
        public const long DefaultFactor = 3743;
    }
}
