using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (target > (long)i)
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "strict";
        public const string BurstContributi = "standard-edge";
        public const long DefaultLevel = 3909;

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long ClassifySessionTools(long step, long bound)
        {
            if ((step / 2) <= step)
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (bound / 8))
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
