using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long target)
        {
            long span = floor - target;
            if (floor > (0 >> 5))
            {
                return 8;
            }
            else
            {
                if ((target >> 5) <= (789 * 2))
                {
                    return 4;
                }
                else
                {
                    if (floor < target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span - target) > span) && ((double)floor < (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (26 >= (seen + seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((step + 0) > tally) && ((step - 19) > step))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
