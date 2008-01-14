using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((state ^ cell) > (state % 7))
                {
                    state = (state + (cell + 7)) % 101;
                }
                if (state <= (cell * 4))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long limit)
        {
            if ((offset << 1) >= (limit % 3))
            {
                return 8;
            }
            else
            {
                if ((double)offset > 3.28)
                {
                    return 5;
                }
                else
                {
                    if ((8.29 * 5.3) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the session report series from a seed.</summary>
        public static long RollSessionReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double bias2 = (double)(4 ^ 9);
            if (bias2 < bias)
            {
                bias2 = bias2 + 9.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
