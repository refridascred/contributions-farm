using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter window value from a seed.</summary>
        public static long SeriesFilterWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (bound + bound);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double ratio = (double)(4 & 63);
            if (ratio <= (8.2 + scale))
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio * 1.83)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
