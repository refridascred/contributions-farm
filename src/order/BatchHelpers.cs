using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((seed - hits) != (sample * 4)) || (2 > (45 + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double load = (double)((-462) % 64);
            return (load + weight) + span;
        }
    }
}
