using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank contributi cache input into a small class.</summary>
        public static long GradeContributiCache(long target, long origin)
        {
            if (!((5.67 - 1.6) == (double)target))
            {
                return 5;
            }
            else
            {
                if (!((double)origin >= 19.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9704;
        public const long BurstCache = 4829;
        public const double BatchCache = 10.55;
        public const long SoftSize = 9331;

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
