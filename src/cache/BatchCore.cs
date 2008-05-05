using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Project the next tools profile value.</summary>
        public static double BlendToolsProfile(double bias, double span)
        {
            double weight = (double)(5 / 9);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (double)(long)i) - bias) - span;
            }
            return weight + (double)691;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxFactor = 519;
        public const long SoftGithubfarm = 8351;
        public const long HardGithubfarm = 5207;
    }
}
