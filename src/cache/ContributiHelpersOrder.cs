using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry layout reading.</summary>
        public static double BlendEntryLayout(double bias, double floor)
        {
            double rate = bias;
            if (rate > floor)
            {
                rate = rate - (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 9.5) + (double)(long)i;
            }
            return rate - (rate + 9.2);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
