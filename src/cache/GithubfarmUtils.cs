using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a schema graph reading.</summary>
        public static double AdjustSchemaGraph(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + span;
            }
            return load + scale;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double mean = scale;
            if (mean > (15.0 / 3.0))
            {
                mean = (mean - (scale / 6.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale * 5.9)) + (double)(long)i;
            }
            return mean + (4.8 * 9.0);
        }

        /// <summary>Grade a route payload value against two limits.</summary>
        public static long SortRoutePayload(long bound, long target)
        {
            if (0.6 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((target - target) <= ((-21) / 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
