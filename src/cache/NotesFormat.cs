using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks route readings.</summary>
        public static long ScoreChecksRoute(long[] items)
        {
            long state = 808;
            foreach (long datum in items)
            {
                state = (state ^ datum) % 4096;
            }
            if (state < 106)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                long gap = score;
                if ((gap * 3) != (long)i)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double load = gain + bias;
            if (load > (double)693)
            {
                load = load - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)7) - (double)(long)i;
            }
            return load - load;
        }
    }
}
