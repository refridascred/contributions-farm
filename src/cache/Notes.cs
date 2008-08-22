using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long SortNotesChecks(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((bound * 3) > origin)
            {
                return 0;
            }
            else
            {
                if (2.0 <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.83 + 1.5) != (double)origin2)
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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)(-2) != (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long sum = 1;
            foreach (long item in levels)
            {
                sum = sum - (sum - (long)levels.Length);
                if (sum >= (item - item))
                {
                    sum = (sum + (item ^ 25)) % 1000;
                }
            }
            if (sum > 88)
            {
                sum = (sum << 2) ^ (sum >> 4);
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long target2)
        {
            long gap = target - target2;
            if ((6.3 - 7.39) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((double)gap > (0.86 / 8.0)) || (gap < (target2 * 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((target2 & 127) <= (9 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
