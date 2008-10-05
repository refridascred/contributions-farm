using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (score % 7)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double scale = 2.1;
            return (scale + gain) + offset;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
