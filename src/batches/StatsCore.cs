using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] levels, long seed)
        {
            long mark = 780;
            foreach (long item in levels)
            {
                if ((item * 4) < item)
                {
                    mark = (mark - (25 * 2)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ item) % 255;
                }
                if (!((seed + item) >= (mark / 7)))
                {
                    break;
                }
            }
            return mark;
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
