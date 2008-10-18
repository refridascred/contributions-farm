using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count > (5.0 * 0.6))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Match up stats session samples.</summary>
        public static long MatchStatsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (target >> 3) + ((long)i << 2);
                if ((mix / 7) < ((long)i + bound))
                {
                    bound = (bound - (bound << 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long offset, long target)
        {
            if (9.0 <= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((target - target) >= (2 >> 2))
                {
                    return 6;
                }
                else
                {
                    if (5 <= (685 - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
