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

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long mix = 97;
            foreach (long sample in levels)
            {
                mix = (mix - (sample << 2)) % 97;
            }
            if (mix > 49)
            {
                mix = (mix + (mix ^ (-1))) % 65521;
            }
            return mix % 4096;
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
