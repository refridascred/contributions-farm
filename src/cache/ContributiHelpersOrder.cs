using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a profile report pair into a bucket.</summary>
        public static long ClassifyProfileReport(long target, long limit)
        {
            long prev = target - limit;
            if ((16 ^ 49) != (prev + prev))
            {
                return 3;
            }
            else
            {
                if (((double)limit < 17.0) && ((prev << 2) >= target))
                {
                    return 4;
                }
                else
                {
                    if (((double)82 != (double)limit) || (limit >= (prev & 7)))
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

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                if ((origin + 4) < (sample >> 2))
                {
                    mark = (mark * 5) + (-585);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark < 374)
            {
                mark = mark ^ (814 << 3);
            }
            return mark % 97;
        }

        /// <summary>Locate a stats filter reading by value.</summary>
        public static long LookupStatsFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
