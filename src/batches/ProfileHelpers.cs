using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the support report entries that pass the check.</summary>
        public static long TallySupportReportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = ((matches + 3) - entry) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of format command readings.</summary>
        public static long TotalFormatCommand(long[] values, long step)
        {
            long score = 43;
            foreach (long value in values)
            {
                score = (((score << 2) ^ (0 + step)) % 97) - value;
            }
            return score;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long target)
        {
            if ((double)bound > (8.0 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (1.1 * 5.85))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
