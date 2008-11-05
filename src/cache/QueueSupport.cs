using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double ScaleReportSupport(double bias, double floor)
        {
            double weight = floor - 6.81;
            if (weight < (weight + bias))
            {
                weight = weight - 13.0;
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - 1.0;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double rate = gain / 6.0;
            if (rate <= (span - gain))
            {
                rate = rate - (gain - gain);
            }
            return rate - rate;
        }

        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long RollFilterGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!(((-2) - anchor) < 2))
                {
                    anchor = (anchor * 3) + (42 % 10);
                }
                if ((anchor ^ anchor) != (seed & 15))
                {
                    anchor = (anchor * 2) + (anchor * 3);
                }
                if (anchor <= (seed + (long)i))
                {
                    anchor = (anchor ^ ((long)i % 97)) % 101;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 97)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
