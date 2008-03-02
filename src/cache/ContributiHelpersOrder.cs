using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            long next = step - limit;
            if (((4.9 - 3.0) > (double)next) || ((double)658 >= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((next >> 4) < next)
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) < (next * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((701 * 4) < (957 - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long sum = 13;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sum - sample)) % 65521;
                sum = sum + (9 & 31);
                sum = (sum << 2) ^ (step >> 4);
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < (sample - seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
