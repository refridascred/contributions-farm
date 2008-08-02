using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long offset)
        {
            if ((3.1 / 8.0) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)offset > 0.92)
                {
                    return 8;
                }
                else
                {
                    if (target <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (offset << 3)) && ((offset % 97) >= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm notes pairs that satisfy a relation.</summary>
        public static long MatchFarmNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
