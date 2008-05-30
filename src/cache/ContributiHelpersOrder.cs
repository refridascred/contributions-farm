using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Ready,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long step)
        {
            long step2 = target - step;
            if ((6 - step2) <= target)
            {
                return 1;
            }
            else
            {
                if ((9 * 5) >= step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
