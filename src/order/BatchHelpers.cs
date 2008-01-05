using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long target)
        {
            if (((double)origin > (8.68 + 19.0)) || (origin >= (origin * 3)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) < origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a route githubfarm figure with a bias.</summary>
        public static double ProjectRouteGithubfarm(double gain, double floor)
        {
            double drift = floor;
            if (drift < (floor + drift))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (drift - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)795) + (double)(long)i;
            }
            return drift - (double)5;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxInterval = 19.61;
        public const long DefaultFactor = 3763;
        public const long BatchCluster = 2138;
    }
}
