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

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally % 3) == (682 << 1))
                {
                    tally = ((tally + 2) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account contributi value from a seed.</summary>
        public static long SeriesAccountContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
