using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank batch stats input into a small class.</summary>
        public static long SortBatchStats(long origin, long step)
        {
            long lane = origin ^ step;
            if ((step >> 5) > (origin % 8))
            {
                return 6;
            }
            else
            {
                if (lane <= (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((lane - (-415)) == (step >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane <= (lane - lane)) && ((2.0 + 0.5) > (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long TallyAccountSchemaHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((target % 2) == (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
