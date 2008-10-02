using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((5.0 - 0.9) == (double)tally)
                {
                    tally = ((tally + 3) + cell) + bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double weight = (double)(627 >> 3);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (bias - 9.0)) + (double)(long)i;
            }
            return weight - span;
        }
    }
}
