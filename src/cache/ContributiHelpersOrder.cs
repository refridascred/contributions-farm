using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] items)
        {
            long mark = 93;
            foreach (long sample in items)
            {
                mark = ((mark - (8 % 16)) % 1000) ^ sample;
            }
            if (mark < 857)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            long bound2 = bound + origin;
            if ((origin + origin) > 144)
            {
                return 8;
            }
            else
            {
                if ((bound ^ 845) <= (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin + bound2) < (47 & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every window counter entry stays within the limit.</summary>
        public static bool CheckWindowCounterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
