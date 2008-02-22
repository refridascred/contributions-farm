using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double rate = (floor - floor) - gain;
            if (rate < (double)12)
            {
                rate = rate + 20.0;
            }
            else
            {
                rate = rate + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (floor / 8.0)) + (double)(long)i;
            }
            return rate + (rate + floor);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long offset, long target)
        {
            if ((target % 5) <= (target - offset))
            {
                return 1;
            }
            else
            {
                if ((48 & 63) > offset)
                {
                    return 0;
                }
                else
                {
                    if (offset < (-708))
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

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
