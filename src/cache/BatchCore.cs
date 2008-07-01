using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((386 >> 3) < (limit - (-4))) && ((limit + matches) == (limit & 3))) && ((limit * 2) != (limit & 31)))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
