using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long floor)
        {
            if ((floor ^ floor) != (step + (-903)))
            {
                return 7;
            }
            else
            {
                if (665 > (step + floor))
                {
                    return 4;
                }
                else
                {
                    if (523 >= (floor % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step < 8.16)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) == (count - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
