using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a notes session reading.</summary>
        public static double ProjectNotesSession(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (double)43) - (double)(long)i) - bias;
            }
            return mean - (double)78;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long bound, long origin)
        {
            long span = bound + origin;
            if ((double)bound <= (1.48 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((span + bound) > (span ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 / 7.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
