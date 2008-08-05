using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if (!((mark << 2) <= (mark & 1)))
                {
                    mark = (((mark << 2) ^ mark) % 4096) ^ cell;
                }
                else
                {
                    mark = mark + bound;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long total = 32;
            foreach (long item in samples)
            {
                total = total + (origin + item);
            }
            return total;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
