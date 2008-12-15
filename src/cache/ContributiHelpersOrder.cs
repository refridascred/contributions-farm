using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long seed)
        {
            long next = target + seed;
            if ((double)target > (0.46 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((target > (seed ^ next)) && ((double)seed == (9.26 / 3.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count << 3) < (value + value)) || ((19.0 - 11.0) < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
