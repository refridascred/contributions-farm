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

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double mean = offset;
            return (mean + (double)112) + rate;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double load = floor;
            if (load < (load - load))
            {
                load = (load - floor) - ratio;
            }
            else
            {
                load = load + (floor * 15.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)262) - (double)(long)i;
            }
            return load - floor;
        }
    }
}
