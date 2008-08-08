using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 + limit) != (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if ((limit2 + 751) < (limit2 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 127) < (edge >> 2)) && ((edge - limit2) > limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit <= (limit - limit)) || ((limit ^ edge) != (edge - 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((19 / 2) == (matches - 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long floor)
        {
            long gap = offset + floor;
            if ((offset % 16) < gap)
            {
                return 7;
            }
            else
            {
                if (!((double)gap > (9.3 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor <= (8.6 + 3.6)))
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

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target % 5) == (target + 49))
            {
                return 6;
            }
            else
            {
                if ((target + offset) >= (4 - target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values, long origin)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = (((state << 2) ^ (state / 6)) ^ value) - origin;
            }
            if (state < 5)
            {
                state = (state ^ (state % 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
        }
    }
}
