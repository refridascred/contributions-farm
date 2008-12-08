using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score - ((long)i & 127)) % 1000;
                if (!(((long)i + score) < score))
                {
                    score = score ^ 698;
                }
                score = (score - (score - score)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double load = (double)(-801) * 15.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + rate;
            }
            return load + (floor * 1.0);
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long RollContextGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if ((double)origin != (4.0 - 20.0))
            {
                return 3;
            }
            else
            {
                if (!((floor / 5) >= 54))
                {
                    return 7;
                }
                else
                {
                    if ((12.0 * 9.9) == (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.0 - 4.31) <= (double)origin))
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
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = (score - (entry & 31)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
