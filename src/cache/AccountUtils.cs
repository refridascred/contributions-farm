using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long mix = 611;
            foreach (long item in data)
            {
                mix = ((mix << 3) ^ (offset / 3)) % 97;
                mix = ((mix * 3) + (item & 15)) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (5 > (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
