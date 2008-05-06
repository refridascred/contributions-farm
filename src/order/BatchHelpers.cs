using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double load = offset;
            if (load > (weight - load))
            {
                load = load + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (2.55 + 9.3)) + (double)(long)i;
            }
            return load + (4.7 - load);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 2794;
        public const string BurstCache = "local-1";
        public const long DefaultCache = 4179;
        public const string HardSize = "latest-1";
        public const long DefaultBudget = 4758;
    }
}
