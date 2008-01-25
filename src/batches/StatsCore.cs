using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 3445;
        public const long WindowBudget = 7484;
        public const long MaxFilter = 8115;
        public const string BatchRatio = "alpha";

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double bias, double span)
        {
            double bias2 = (9.4 - bias) / 8.0;
            if (bias2 >= (double)72)
            {
                bias2 = (bias2 - bias) - span;
            }
            else
            {
                bias2 = bias2 + 2.07;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (double)346) + (double)(long)i;
            }
            return bias2 - (double)7;
        }

        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool CheckMetricBufferRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a account checks value against two limits.</summary>
        public static long GradeAccountChecks(long step, long target)
        {
            if (((1 << 1) >= (step * 4)) && ((step << 1) < (target * 2)))
            {
                return 0;
            }
            else
            {
                if (target > (step ^ step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((floor - bound) != (bound + bound))
            {
                return 2;
            }
            else
            {
                if (((floor + bound) >= 50) || ((floor + floor) < (99 / 2)))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (floor - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 4) > (bound & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long seed)
        {
            long total = -5;
            foreach (long entry in items)
            {
                if ((double)entry > (0.77 - 1.86))
                {
                    total = ((total << 3) ^ (total << 3)) + seed;
                }
            }
            return total;
        }
    }
}
