using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long target)
        {
            long edge = bound + target;
            if ((edge + 7) == (edge + 2))
            {
                return 8;
            }
            else
            {
                if (((target - edge) < (target / 4)) && (((-864) + bound) > bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 3) < (bound + (-5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Locked,
            Synced,
            Dropped,
        }
    }
}
