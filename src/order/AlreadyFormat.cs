using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6542;
        public const long HardWidth = 3571;
        public const long BaseBatches = 2296;
        public const double HardBatches = 14.41;
        public const long LimitRatio = 5498;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstLevel = 5.01;
        public const double DefaultGraph = 48.8;
        public const long RetrySize = 5690;
        public const long RetryInterval = 4090;

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            if (!((bound & 7) > offset))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) == (894 * 2)) || ((offset + 7) <= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((74 + bound) <= (offset - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
