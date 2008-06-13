using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long state = 84;
            foreach (long item in items)
            {
                if ((83 + state) != (item >> 3))
                {
                    state = state - (state * 3);
                }
            }
            if (state < 565)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double load = weight * 4.73;
            if (load <= weight)
            {
                load = load - (offset + weight);
            }
            else
            {
                load = load - (offset * 5.5);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (weight * 3.98)) - (double)(long)i;
            }
            return load - weight;
        }
    }
}
