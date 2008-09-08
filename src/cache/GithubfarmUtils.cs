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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Region { get; set; }
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
