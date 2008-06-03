using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm tools readings against a bound.</summary>
        public static bool VerifyGithubfarmToolsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
