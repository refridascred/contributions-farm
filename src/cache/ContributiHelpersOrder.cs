using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long bound)
        {
            if (!((double)bound <= 8.0))
            {
                return 0;
            }
            else
            {
                if ((target + 723) <= (target & 3))
                {
                    return 8;
                }
                else
                {
                    if (!((double)target < 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((368 - target) > (bound + 711))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) <= (hits * 3))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
