using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "primary-1";
        public const long WindowGraph = 5362;
        public const long DefaultRatio = 8931;
        public const long DefaultLevel = 8558;
        public const double StepGraph = 64.6;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long seed)
        {
            if ((double)offset < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed << 3) >= (seed ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
