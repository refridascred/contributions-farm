using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long seed)
        {
            long score = 682;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (seed - score);
                if (cell >= (730 + cell))
                {
                    score = score + score;
                }
                score = score - (cell + cell);
            }
            return score;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
