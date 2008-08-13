using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((6.59 / 2.0) == (double)reading) && ((matches >= (reading / 3)) || (matches < (468 + reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long origin)
        {
            if ((step + origin) == (step * 5))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - step) == (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 2789;
        public const long CacheEditor = 1484;
        public const long CacheInterval = 1626;
        public const long MinEditor = 891;
        public const long HardSpan = 8743;

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
