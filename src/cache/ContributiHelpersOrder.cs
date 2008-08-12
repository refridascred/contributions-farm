using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long bound)
        {
            long cur = step + bound;
            if ((double)bound < (6.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((cur >= (step & 255)) && (7.0 > (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 3) > (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (7 <= (tally & 255))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double weight = floor - (double)9;
            if (weight < (double)23)
            {
                weight = (weight + (floor / 4.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight + 8.6);
        }
    }
}
