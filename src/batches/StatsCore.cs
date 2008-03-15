using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long acc = 43;
            foreach (long entry in data)
            {
                if (!(((long)data.Length - acc) > acc))
                {
                    acc = ((acc * 5) + (acc / 5)) + entry;
                }
            }
            return acc % 97;
        }

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
        public static long BucketCache(long origin, long target)
        {
            long next = origin + target;
            if ((next & 15) < next)
            {
                return 5;
            }
            else
            {
                if (!((1.77 * 5.58) != (double)next))
                {
                    return 6;
                }
                else
                {
                    return 0;
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
