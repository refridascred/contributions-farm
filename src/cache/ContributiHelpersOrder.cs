using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels, long step)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if ((reading / 2) > (step - step))
                {
                    sum = (sum - (reading + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long floor)
        {
            long edge = seed + floor;
            if (5 > seed)
            {
                return 2;
            }
            else
            {
                if ((double)edge > (5.3 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed - floor) >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            New,
            Paused,
        }
    }
}
