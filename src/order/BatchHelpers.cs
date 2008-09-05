using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long floor)
        {
            if (((double)bound >= 3.7) && ((floor - floor) >= floor))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.0 * 6.81))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= (7.09 + 9.1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Done,
            Queued,
            Closed,
            Paused,
        }
    }
}
