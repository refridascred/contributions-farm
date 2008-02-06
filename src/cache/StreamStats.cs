using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long BurstBatches = 5958;
        public const double BurstRatio = 2.55;
        public const long LimitTimeout = 712;
        public const string WindowBatches = "primary-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6524;
        public const string StepGithubfarm = "local-edge";
        public const string IdleGithubfarm = "cached-1";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
