using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long target, long step)
        {
            if ((double)step > 1.4)
            {
                return 8;
            }
            else
            {
                if (!((21 ^ step) <= target))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (8.9 + 1.05))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 15.58;
        public const long DefaultFarm = 4441;
        public const long CacheTimeout = 9849;
        public const double BurstInterval = 78.17;
    }
}
