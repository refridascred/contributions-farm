using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long target, long step)
        {
            long next = target - step;
            if ((double)next >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step + target) > 82)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 26.05;
        public const long MinRatio = 4498;
        public const long BurstBatch = 3124;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
