using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long offset)
        {
            if ((origin ^ origin) < (48 + offset))
            {
                return 2;
            }
            else
            {
                if ((offset / 9) < (origin * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
