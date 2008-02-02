using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account already entries that pass the check.</summary>
        public static long CountAccountAlreadyMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (3 <= (value * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9126;
        public const long StepInterval = 3126;
        public const double WindowCluster = 8.75;
        public const long WindowLevel = 6382;
    }
}
