using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - (bound % 60);
                acc = (acc << 2) ^ (498 + acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches <= 4.17) && (((matches + matches) == (datum % 8)) && (matches >= datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks tools readings against a rule.</summary>
        public static long AuditChecksToolsOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)item == (1.89 + 6.59)) || ((seed << 1) < seed))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long offset)
        {
            if ((157 / 3) >= (offset / 5))
            {
                return 2;
            }
            else
            {
                if (!((offset - limit) < (limit & 255)))
                {
                    return 4;
                }
                else
                {
                    if (offset < (offset * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 97) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
