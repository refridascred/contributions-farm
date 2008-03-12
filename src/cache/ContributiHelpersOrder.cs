using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double AdjustQueueMetrics(double scale, double floor)
        {
            double rate = 4.25;
            if (rate >= (double)42)
            {
                rate = rate + (scale * 4.3);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long floor)
        {
            long offset = step - floor;
            if (3.39 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)step <= (5.49 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((1 & 31) == (offset << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 5) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
