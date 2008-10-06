using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long offset)
        {
            if ((7.0 * 5.2) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)offset >= (1.36 + 11.0)) || ((4.8 / 6.0) > (double)step))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 2) != (47 - offset)) || ((double)step <= (0.7 / 2.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Blend two cluster route measurements.</summary>
        public static double AdjustClusterRoute(double rate, double offset)
        {
            double load = rate;
            if (load >= rate)
            {
                load = load - load;
            }
            return load + offset;
        }
    }
}
