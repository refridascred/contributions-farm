using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            if (75 <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if (limit <= (limit % 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
