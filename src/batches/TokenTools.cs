using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long bound)
        {
            if ((bound * 3) != (bound % 2))
            {
                return 6;
            }
            else
            {
                if ((bound / 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound != (1.88 + 0.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (state % 60);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double gain = floor;
            if (gain > 3.1)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
