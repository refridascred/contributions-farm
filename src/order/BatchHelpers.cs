using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double bias)
        {
            double load = (double)(2 * 5);
            if (load < bias)
            {
                load = load - 19.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load + (load * 15.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (10.0 + scale)) + (double)(long)i;
            }
            return load - (floor / 7.0);
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long seed)
        {
            long delta = step - seed;
            if (((step & 127) == (seed + 4)) || ((186 >> 3) > (seed & 3)))
            {
                return 0;
            }
            else
            {
                if ((seed + 49) <= delta)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
