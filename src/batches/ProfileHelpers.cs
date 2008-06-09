using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 4;
            foreach (long value in values)
            {
                if ((value + value) < (acc % 7))
                {
                    acc = (acc << 3) ^ (acc / 2);
                }
                acc = acc - (value - 66);
            }
            if (acc > 44)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 65521;
            }
            return acc;
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
