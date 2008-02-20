using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long offset)
        {
            long gap = target + offset;
            if ((13.0 - 6.3) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (((4.8 / 4.0) >= (double)target) || (offset >= (gap * 2)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchDepth = 377;
        public const long MinAccount = 1310;
        public const long WindowAccount = 5646;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchSize = 55.46;
        public const double MaxOrder = 25.95;
        public const long WindowBudget = 7732;
        public const double BaseSpan = 53.71;
    }
}
