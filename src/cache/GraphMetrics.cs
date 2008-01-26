using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer filter samples.</summary>
        public static long CompareBufferFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((48 - 625) < ((long)values.Length << 3))
                {
                    matches = ((matches + 2) + entry) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long DeriveCounterChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = score + (offset & 7);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long target)
        {
            long gap = origin + target;
            if ((origin >> 1) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((origin + 40) < (gap / 6))
                {
                    return 5;
                }
                else
                {
                    if (!((gap + origin) == (75 - 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap > (origin + target)) || ((-67) > (gap / 9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
