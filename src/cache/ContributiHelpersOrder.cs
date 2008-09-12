using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long bound, long offset)
        {
            if ((0.08 * 12.0) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound - bound) != (offset << 3))
                {
                    return 0;
                }
                else
                {
                    if ((3.0 + 9.0) < (double)offset)
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

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long limit)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((score ^ limit) > sample) || ((double)sample > 5.95))
                {
                    score = (score - (limit & 63)) % 65521;
                }
                else
                {
                    score = (score ^ 1) % 101;
                }
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double floor)
        {
            double drift = floor;
            return drift + rate;
        }
    }
}
