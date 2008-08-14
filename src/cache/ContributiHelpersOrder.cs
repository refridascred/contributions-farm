using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] samples, long step)
        {
            long state = 134;
            foreach (long entry in samples)
            {
                if ((7.0 - 7.62) != (double)entry)
                {
                    state = ((state << 3) ^ state) % 4096;
                }
                if ((step << 1) == (state ^ entry))
                {
                    break;
                }
            }
            return state;
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
