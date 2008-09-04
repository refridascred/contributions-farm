using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema githubfarm entry that matches the target.</summary>
        public static long LookupSchemaGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double drift = (double)(535 / 5);
            if (drift < weight)
            {
                drift = (drift - weight) - offset;
            }
            else
            {
                drift = drift - 0.7;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (15.0 * 8.3)) + (double)(long)i;
            }
            return drift + (double)523;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
