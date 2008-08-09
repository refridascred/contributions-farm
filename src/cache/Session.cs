using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 8210;
        public const string BatchSpan = "primary-1";
        public const long StepSize = 3218;
        public const long WindowInterval = 1947;
        public const string BurstWidth = "alpha-edge";

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Idle,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
