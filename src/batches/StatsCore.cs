using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 8975;
        public const long StepStream = 3098;
        public const double DefaultStream = 56.17;
        public const double BurstStream = 78.28;
        public const long MinStream = 7422;

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long OverlapTokenNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long target, long bound)
        {
            if ((double)target == (10.0 - 5.08))
            {
                return 2;
            }
            else
            {
                if (((-9) >> 1) >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (1.9 - 12.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ 70) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step / 8) <= step)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinRatio = 74.89;
        public const long DefaultProfile = 6158;
        public const string BaseTimeout = "local";
        public const double MaxProfile = 12.64;
        public const long StepProfile = 8537;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long floor)
        {
            long lane = target + floor;
            if ((lane & 3) == (target / 6))
            {
                return 3;
            }
            else
            {
                if (!((56 * 3) >= lane))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (6.72 - 0.4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
