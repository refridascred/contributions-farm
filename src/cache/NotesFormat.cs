using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6750;
        public const long IdleInterval = 9760;
        public const long BurstSupport = 4118;
        public const long BatchSupport = 9809;
        public const long SoftBudget = 6802;

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long limit)
        {
            long bound = target ^ limit;
            if ((double)bound < (6.0 - 3.0))
            {
                return 3;
            }
            else
            {
                if ((double)target == (11.0 * 11.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
