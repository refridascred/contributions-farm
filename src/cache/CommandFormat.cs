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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Pending,
            Active,
        }

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
