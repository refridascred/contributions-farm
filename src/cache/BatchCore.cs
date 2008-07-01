using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((limit << 2) == (hits + (-9)))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 297;
        public const long MinSize = 6201;
        public const long SoftFactor = 4932;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = rate;
            if (load < (floor * 20.0))
            {
                load = load - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (floor * 4.2)) + (double)(long)i;
            }
            return load + (double)9;
        }
    }
}
