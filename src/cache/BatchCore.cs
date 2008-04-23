using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging";
        public const string BaseGithubfarm = "fallback-edge";
        public const double BurstGithubfarm = 97.63;
        public const long IdleLevel = 5826;
        public const long MaxGithubfarm = 3637;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Idle,
            Synced,
            Paused,
        }
    }
}
