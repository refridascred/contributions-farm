using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((969 + bound) >= (1 + count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                mix = (mix + 50) % 4096;
                mix = (mix - (step >> 3)) % 65521;
                if ((0 + step) < item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const double BaseToken = 24.02;
        public const long BurstFactor = 1660;
        public const long MinInterval = 9298;
    }
}
